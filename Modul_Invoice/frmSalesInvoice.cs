using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PreAccountancy.Modul_Invoice
{
    public partial class frmSalesInvoice : DevExpress.XtraEditors.XtraForm
    {
        Functions.Forms forms = new Functions.Forms();
        Functions.DbDataContext db = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        int CurrentID = -1;
        int PaymentID = -1;
        int InvoiceID = -1;
        int WaybillID = -1;
        string PaymentPlace = "";
        bool Edit = false;
        bool OpenWaybill = false;

        public frmSalesInvoice()
        {
            InitializeComponent();
        }
        public frmSalesInvoice(bool Edit, int ID)
        {
            InitializeComponent();
        }
        private void btnStockSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StockID = forms.StockList(true);
            if (StockID > 0)
            {
                Functions.TBL_Stock stock = db.TBL_Stocks.First(s => s.ID == StockID);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("Quantity", "0");
                gridView1.SetFocusedRowCellValue("Barcode", stock.StockBarcode);
                gridView1.SetFocusedRowCellValue("StockCode", stock.StockCode);
                gridView1.SetFocusedRowCellValue("StockName", stock.StockName);
                gridView1.SetFocusedRowCellValue("Unit", stock.StockUnit);
                gridView1.SetFocusedRowCellValue("UnitPrice", stock.StockSalePrice);
                gridView1.SetFocusedRowCellValue("TAX", stock.StockSaleTAX);



            }
            frmMain.Transfer = -1;

        }
        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            txtInvoiceDate.Text = DateTime.Now.ToShortDateString();
            txtWaybillDate.Text = DateTime.Now.ToShortDateString();

        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                decimal Quantity = 0, UnitPrice = 0, Total = 0;

                if (e.Column.Name != "colTotal")
                {
                    Quantity = Decimal.Parse(gridView1.GetFocusedRowCellValue("Quantity").ToString());
                    if (gridView1.GetFocusedRowCellValue("UnitPrice").ToString() != "") UnitPrice = decimal.Parse(gridView1.GetFocusedRowCellValue("UnitPrice").ToString());
                    Total = Quantity * UnitPrice;
                    gridView1.SetFocusedRowCellValue("Total", Total.ToString());
                    Calculate();

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
        void Calculate()
        {
            try
            {
                decimal UnitPrice = 0, Quantity = 0, TopTotal = 0, SubTotal = 0, TAX = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    UnitPrice = decimal.Parse(gridView1.GetRowCellValue(i, "UnitPrice").ToString());
                    Quantity = decimal.Parse(gridView1.GetRowCellValue(i, "Quantity").ToString());
                    TAX = decimal.Parse(gridView1.GetRowCellValue(i, "TAX").ToString()) / 100 + 1;
                    SubTotal += Quantity * UnitPrice;
                    TopTotal += decimal.Parse(gridView1.GetRowCellValue(i, "Total").ToString()) * TAX;
                }
                txtSubTotal.Text = SubTotal.ToString("0.00");
                txtTAX.Text = (TopTotal - SubTotal).ToString("0.00");
                txtTopTotal.Text = TopTotal.ToString("0.00");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void txtCurrentCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = forms.CurrentList(true);
            if (ID > 0)
            {
                CurrentSelect(ID);
            }
            frmMain.Transfer = -1;
        }
        void CurrentSelect(int ID)
        {
            try
            {
                CurrentID = ID;
                Functions.TBL_Current current = db.TBL_Currents.First(s => s.ID == CurrentID);
                txtCurrentCode.Text = current.CurrentCode;
                txtCurrentName.Text = current.CurrentName;
            }
            catch (Exception EX)
            {

                messages.Error(EX);
            }
        }
        private void txtInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtInvoiceType.SelectedIndex == 0)
            {
                pnlPaymentPlace.Enabled = false;
            }
            else
            {
                pnlPaymentPlace.Enabled = true;
            }
        }
        private void txtPaymentPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPaymentPlace.SelectedIndex == 0)
            {
                txtAccountName.Enabled = false;
                txtAccountNo.Enabled = false;
                txtSafeName.Enabled = true;
                txtSafeCode.Enabled = true;
            }
            else
            {
                txtAccountName.Enabled = true;
                txtAccountNo.Enabled = true;
                txtSafeName.Enabled = false;
                txtSafeCode.Enabled = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Clear()
        {
            CurrentID = -1;
            PaymentID = -1;
            InvoiceID = -1;
            WaybillID = -1;
            PaymentPlace = "";
            Edit = false;
            OpenWaybill = false;
            txtDescription.Text = "";
            txtTopTotal.Text = "0.00";
            txtCurrentName.Text = "";
            txtCurrentCode.Text = "";
            txtInvoiceNo.Text = "";
            txtInvoiceDate.Text = DateTime.Now.ToShortDateString();
            txtInvoiceType.SelectedIndex = 0;
            txtSubTotal.Text = "0.00";
            txtAccountName.Text = "";
            txtAccountNo.Text = "";
            txtWaybillDate.Text = DateTime.Now.ToShortTimeString();
            txtWaybillNo.Text = "";
            txtSafeCode.Text = "";
            txtSafeName.Text = "";
            txtTAX.Text = "0.00";
            txtPaymentPlace.SelectedIndex = 0;
            frmMain.Transfer = -1;
            for (int i = 0; i < gridView1.RowCount+1; i++)
            {
                gridView1.DeleteRow(0);
            }

        }
        void NewInvoiceSave()
        {
            try
            {
                Functions.TBL_INVOICE invoice = new Functions.TBL_INVOICE();
                invoice.Description = txtDescription.Text;
                invoice.CurrentCode = txtCurrentCode.Text;
                invoice.InvoiceNo = txtInvoiceNo.Text;
                invoice.InvoiceType = "Satış Faturası";
                invoice.TopTotal = decimal.Parse(txtTopTotal.Text);
                invoice.WaybillID = WaybillID;
                /*ToDo*/
                invoice.PaymentType = PaymentPlace;
                invoice.PaymentID = PaymentID;
                invoice.Date = DateTime.Parse(txtInvoiceDate.Text);
                invoice.SaveDate = DateTime.Now;
                invoice.SaveUser = frmMain.UserID;
                db.TBL_INVOICEs.InsertOnSubmit(invoice);
                db.SubmitChanges();
                InvoiceID = invoice.Id;
                if (WaybillID < 0)
                {
                    Functions.TBL_WAYBILL waybill = new Functions.TBL_WAYBILL();
                    waybill.Description = txtDescription.Text;
                    waybill.CurrentCode = txtCurrentCode.Text;
                    waybill.InvoiceID = invoice.Id;
                    waybill.WaybillNo = txtWaybillNo.Text;
                    waybill.Date = DateTime.Parse(txtWaybillDate.Text);
                    waybill.SaveDate = DateTime.Now;
                    waybill.SaveUser = frmMain.UserID;
                    db.TBL_WAYBILLs.InsertOnSubmit(waybill);
                    db.SubmitChanges();
                    WaybillID = waybill.Id;
                }
                Functions.TBL_STOCKMOVEMENT[] stockMovement = new Functions.TBL_STOCKMOVEMENT[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    stockMovement[i] = new Functions.TBL_STOCKMOVEMENT();
                    stockMovement[i].UnitPrice = decimal.Parse(gridView1.GetRowCellValue(i, "UnitPrice").ToString());
                    stockMovement[i].InvoiceID = invoice.Id;
                    stockMovement[i].GCCode = "C";
                    stockMovement[i].WaybillID = WaybillID;
                    stockMovement[i].TAX = decimal.Parse(gridView1.GetRowCellValue(i, "TAX").ToString());
                    stockMovement[i].Quantity = int.Parse(gridView1.GetRowCellValue(i, "Quantity").ToString());
                    stockMovement[i].StockCode = gridView1.GetRowCellValue(i, "StockCode").ToString();
                    stockMovement[i].Type = "Satış Faturası";
                    stockMovement[i].SaveDate = DateTime.Now;
                    stockMovement[i].SaveUser = frmMain.UserID;
                    db.TBL_STOCKMOVEMENTs.InsertOnSubmit(stockMovement[i]);

                }
                db.SubmitChanges();
                Functions.TBL_CurrentMovement currentMovement = new Functions.TBL_CurrentMovement();
                currentMovement.Description = txtInvoiceNo.Text + " no'lu satış faturası tutarı";
                if (txtInvoiceType.SelectedIndex == 0)
                {
                    currentMovement.Credit = 0;
                    currentMovement.Debt = decimal.Parse(txtTopTotal.Text);

                }
                else if (txtInvoiceType.SelectedIndex == 1)
                {
                    currentMovement.Debt = decimal.Parse(txtTopTotal.Text);
                    currentMovement.Credit = decimal.Parse(txtTopTotal.Text);
                }
                currentMovement.CurrentID = CurrentID;
                currentMovement.Date = DateTime.Now;
                currentMovement.Type = "SF";
                currentMovement.DocumentType = "Satış Faturası";
                currentMovement.DocumentID = invoice.Id;
                currentMovement.SaveDate = DateTime.Now;
                currentMovement.SaveUser = frmMain.UserID;
                db.TBL_CurrentMovements.InsertOnSubmit(currentMovement);
                db.SubmitChanges();
                messages.NewRecord("Yeni Fatura Kaydı Başarı ile Yapılmıştır...");
                Clear();

            }
            catch (Exception EX)
            {

                messages.Error(EX);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewInvoiceSave();
        }
    }

}