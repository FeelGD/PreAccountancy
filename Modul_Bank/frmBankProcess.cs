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
    public partial class frmBankProcess : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();

        bool Edit = false;
        int ProcessID = -1;
        int BankID = -1;

        public frmBankProcess()
        {
            InitializeComponent();
        }

        private void frmBankProcess_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }

        public void Open(int ID)
        {
            try
            {
                Edit = true;
                ProcessID = ID;
                Functions.TBL_BANKMOVEMENT bankmovement = DB.TBL_BANKMOVEMENTs.First(s => s.Id == ProcessID);
                OpenBank(bankmovement.BankID.Value);
                txtDescription.Text = bankmovement.Description;
                txtDocumentNo.Text = bankmovement.DocumentNo;
                txtDate.Text = bankmovement.Date.Value.ToShortDateString();
                txtAmount.Text = bankmovement.Amount.ToString();
                if (bankmovement.GCCode == "G") radioInflow.Checked = true;
                if (bankmovement.GCCode == "C") radioOutflow.Checked = true;

            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }
        void OpenBank(int ID)
        {
            try
            {
                BankID = ID;
                txtAccountName.Text = DB.TBL_BANKs.First(s => s.Id == BankID).AccountName;
                txtAccountNo.Text = DB.TBL_BANKs.First(s => s.Id == BankID).AccountNo;

            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        void Clear()
        {
            txtAccountNo.Text = "";
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtDescription.Text = "";
            txtAccountName.Text = "";
            txtDocumentNo.Text = "";
            txtAmount.Text = "0";
            Edit = false;
            ProcessID = -1;
            BankID = -1;
        }
        void NewSave()
        {
            try
            {
                Functions.TBL_BANKMOVEMENT bankMovement = new Functions.TBL_BANKMOVEMENT();
                bankMovement.Description = txtDescription.Text;
                bankMovement.BankID = BankID;
                bankMovement.DocumentNo = txtDocumentNo.Text;
                bankMovement.DocumentType = "Banka İşlemi";
                if (radioInflow.Checked) bankMovement.GCCode = "G";
                if (radioOutflow.Checked) bankMovement.GCCode = "C";
                bankMovement.Date = DateTime.Parse(txtDate.Text);
                bankMovement.Amount = decimal.Parse(txtAmount.Text);
                bankMovement.SaveDate = DateTime.Now;
                bankMovement.SaveUser = frmMain.UserID;
                DB.TBL_BANKMOVEMENTs.InsertOnSubmit(bankMovement);
                DB.SubmitChanges();
                messages.NewRecord("Banka işlemi kaydı yapılmıştır.");
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
                Functions.TBL_BANKMOVEMENT bankMovement = DB.TBL_BANKMOVEMENTs.First(s=>s.Id==ProcessID);
                bankMovement.Description = txtDescription.Text;
                bankMovement.BankID = BankID;
                bankMovement.DocumentNo = txtDocumentNo.Text;
                bankMovement.DocumentType = "Banka İşlemi";
                if (radioInflow.Checked) bankMovement.GCCode = "G";
                if (radioOutflow.Checked) bankMovement.GCCode = "C";
                bankMovement.Date = DateTime.Parse(txtDate.Text);
                bankMovement.Amount = decimal.Parse(txtAmount.Text);
                bankMovement.EditDate = DateTime.Now;
                bankMovement.EditUser = frmMain.UserID;
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
                DB.TBL_BANKMOVEMENTs.DeleteOnSubmit(DB.TBL_BANKMOVEMENTs.First(s => s.Id == ProcessID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        private void txtAccountName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
int Id = forms.BankList(true);
            if (Id > 0) OpenBank(Id);
            frmMain.Transfer = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && ProcessID > 0 && messages.Update() == DialogResult.Yes) Update();
            else NewSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && ProcessID > 0 && messages.Delete() == DialogResult.Yes) Delete();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccountName_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}