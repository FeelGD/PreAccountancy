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

namespace PreAccountancy.Modul_Bank
{
    public partial class frmBankOpeningCard : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Number number = new Functions.Number();

        bool Edit = false;
        int SelectionID = -1;



        public frmBankOpeningCard()
        {
            InitializeComponent();
        }

        private void frmBankOpeningCard_Load(object sender, EventArgs e)
        {
            Lists();
        }
        void Clear()
        {
            txtAccountNo.Text = "";
            txtAccountType.Text = "";
            txtAuthorized.Text = "";
            txtAuthorizedMail.Text = "";
            txtBankAddress.Text = "";
            txtBankBranch.Text = "";
            txtBankBranchPhone.Text = "";
            txtBankName.Text = "";
            txtIBAN.Text = "";
            Edit = false;
            SelectionID = -1;
            Lists();
        }
        void Lists()
        {
            var lst = from s in DB.TBL_BANKs
                      select s;
            gridControl1.DataSource = lst;
        }

        void NewSave()
        {
            try
            {
                Functions.TBL_BANK bank = new Functions.TBL_BANK();
                bank.Address = txtBankAddress.Text;
                bank.BankName = txtBankName.Text;
                bank.AccountName = txtAccountType.Text;
                bank.AccountNo = txtAccountNo.Text;
                bank.IBAN = txtIBAN.Text;
                bank.Branch = txtBankBranch.Text;
                bank.Phone = txtBankBranchPhone.Text;
                bank.Authorized = txtAuthorized.Text;
                bank.AuthorizedMail = txtAuthorizedMail.Text;
                bank.SaveDate = DateTime.Now;
                bank.SaveUser = frmMain.UserID;
                DB.TBL_BANKs.InsertOnSubmit(bank);
                DB.SubmitChanges();
                messages.NewRecord("Yeni banka kaydı açılmıştır.");
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }
        void Update()
        {
            try
            {
                Functions.TBL_BANK bank = DB.TBL_BANKs.First(s => s.Id == SelectionID);
                bank.Address = txtBankAddress.Text;
                bank.BankName = txtBankName.Text;
                bank.AccountName = txtAccountType.Text;
                bank.AccountNo = txtAccountNo.Text;
                bank.IBAN = txtIBAN.Text;
                bank.Branch = txtBankBranch.Text;
                bank.Phone = txtBankBranchPhone.Text;
                bank.Authorized = txtAuthorized.Text;
                bank.AuthorizedMail = txtAuthorizedMail.Text;
                bank.EditDate = DateTime.Now;
                bank.EditUser = frmMain.UserID;
                DB.SubmitChanges();
                messages.Update(true);
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }
        void Delete()
        {
            try
            {
                DB.TBL_BANKs.DeleteOnSubmit(DB.TBL_BANKs.First(s => s.Id == SelectionID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }

        }
        void Select()
        {
            try
            {
                Edit = true;
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                if (SelectionID > 0) Open();

            }
            catch (Exception)
            {

                Edit = false;
                SelectionID = -1;
            }
        }
        void Open()
        {
            try
            {
                Functions.TBL_BANK bank = DB.TBL_BANKs.First(s => s.Id == SelectionID);
                txtBankAddress.Text = bank.Address;
                txtBankName.Text = bank.BankName;
                txtAccountType.Text = bank.AccountName;
                txtAccountNo.Text = bank.AccountNo;
                txtIBAN.Text = bank.IBAN;
                txtBankBranch.Text = bank.Branch;
                txtBankBranchPhone.Text = bank.Phone;
                txtAuthorized.Text = bank.Authorized;
                txtAuthorizedMail.Text = bank.AuthorizedMail;
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && messages.Update() == DialogResult.Yes) Update();
            else NewSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && messages.Delete() == DialogResult.Yes) Delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Select();
        }
    }
}