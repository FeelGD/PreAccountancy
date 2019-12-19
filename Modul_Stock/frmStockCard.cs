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

namespace PreAccountancy.Modul_Stock
{
    public partial class frmStockCard : DevExpress.XtraEditors.XtraForm
    {

        //picture && photo



        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages Messages = new Functions.Messages();
        Functions.Number Numbers = new Functions.Number();
        Functions.Forms Forms = new Functions.Forms();
        Functions.Photos Photos = new Functions.Photos();

        bool Edit = false;
        bool SelectedPhoto = false;
        int GroupID = -1;
        int StockID = -1;

        OpenFileDialog File = new OpenFileDialog();


        public frmStockCard()
        {
            InitializeComponent();

        }

        private void frmStockCard_Load(object sender, EventArgs e)
        {
            txtStockCode.Text = Numbers.StockCodeNumber();

        }
        void Clear()
        {
            txtStockCode.Text = Numbers.StockCodeNumber();
            txtStockGroupCode.Text = "";
            txtStockGroupName.Text = "";
            txtStockName.Text = "";
            txtSaleTAX.Text = "0";
            txtSalePrice.Text = "0";
            txtPurchaseTAX.Text = "0";
            txtPurchasePrice.Text = "0";
            txtboxUnit.SelectedIndex = 0;
            txtBarcode.Text = "";
            pictureBox1.Image = null;
            Edit = false;
            SelectedPhoto = false;
            GroupID = -1;
            StockID = -1;
            frmMain.Transfer = -1;

        }

        void SelectPhoto()
        {
            File.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (File.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = File.FileName;
                SelectedPhoto = true;
            }
        }

        private void btnPictureSelect_Click(object sender, EventArgs e)
        {
            SelectPhoto();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(Edit&&StockID>0 && Messages.Update() == DialogResult.Yes)
            {
                Update();

            }
            else
            {
                NewSave();
            }
        }


        public void Open(int ID)
        {
            Edit = true;
            StockID = ID;
            Functions.TBL_Stock stock = DB.TBL_Stocks.First(s => s.ID == StockID);
            OpenGroup(stock.StockGroupID.Value);
            pictureBox1.Image = Photos.GetPhoto(stock.StockPicture.ToArray());
            txtPurchasePrice.Text = stock.StockPurchasePrice.ToString();
            txtPurchaseTAX.Text = stock.StockPurchaseTAX.ToString();
            txtBarcode.Text = stock.StockBarcode;
            txtboxUnit.Text = stock.StockUnit;
            txtSalePrice.Text = stock.StockSalePrice.ToString();
            txtSaleTAX.Text = stock.StockSaleTAX.ToString();
            txtStockName.Text = stock.StockName;
            txtStockCode.Text = stock.StockCode;

        }


        void NewSave()
        {
            try
            {
                Functions.TBL_Stock stock = new Functions.TBL_Stock();
                stock.StockName = txtStockName.Text;
                stock.StockPurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                stock.StockPurchaseTAX = decimal.Parse(txtPurchaseTAX.Text);
                stock.StockBarcode = txtBarcode.Text;
                stock.StockUnit = txtboxUnit.Text;
                stock.StockGroupID = GroupID;
                stock.StockCode = txtStockCode.Text;
                stock.StockPicture = new System.Data.Linq.Binary(Photos.AddPhoto(pictureBox1.Image));
                stock.StockSalePrice = decimal.Parse(txtSalePrice.Text);
                stock.StockSaleTAX = decimal.Parse(txtSaleTAX.Text);
                stock.StockSaveDate = DateTime.Now;
                stock.StockSaveUser = frmMain.UserID;
                DB.TBL_Stocks.InsertOnSubmit(stock);
                DB.SubmitChanges();
                Messages.NewRecord("Yeni stok kaydı oluşturuldu.");
                Clear();
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }

        }

        void Update()
        {
            try
            {
                Functions.TBL_Stock stock = DB.TBL_Stocks.First(s => s.ID == StockID);
                stock.StockName = txtStockName.Text;
                stock.StockPurchasePrice = decimal.Parse(txtPurchasePrice.Text);
                stock.StockPurchaseTAX = decimal.Parse(txtPurchaseTAX.Text);
                stock.StockBarcode = txtBarcode.Text;
                stock.StockUnit = txtboxUnit.Text;
                stock.StockGroupID = GroupID;
                stock.StockCode = txtStockCode.Text;
               if(SelectedPhoto) stock.StockPicture = new System.Data.Linq.Binary(Photos.AddPhoto(pictureBox1.Image));
                stock.StockSalePrice = decimal.Parse(txtSalePrice.Text);
                stock.StockSaleTAX = decimal.Parse(txtSaleTAX.Text);
                stock.StockEditDate = DateTime.Now;
                stock.StockEditUser = frmMain.UserID;
                DB.SubmitChanges();
                Messages.Update(true);
                Clear();
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }

        void Delete()
        {
            try
            {
                DB.TBL_Stocks.DeleteOnSubmit(DB.TBL_Stocks.First(s => s.ID == StockID));
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }

        void OpenGroup(int ID)
        {
            GroupID = ID;
            txtStockGroupName.Text = DB.TBL_StockGroups.First(s => s.ID == GroupID).GroupName;
            txtStockGroupCode.Text= DB.TBL_StockGroups.First(s => s.ID == GroupID).GroupCode;
        }

        private void txtStockCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Forms.StockList(true);
            if (ID > 0)
            {
                Open(ID);
              
            }  frmMain.Transfer = -1;
        }

        private void txtStockGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Forms.StockGroup(true);
            if (ID>0)
            {
                OpenGroup(ID);
            }
            frmMain.Transfer = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && StockID > 0 && Messages.Delete() == DialogResult.Yes) Delete();
        }
    }
}