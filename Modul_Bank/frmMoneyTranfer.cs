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
    public partial class frmMoneyTranfer : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();

        bool Edit = false;
        int BankID = -1;
        int CurrentID = -1;
        int ProcessID = -1;

        public frmMoneyTranfer()
        {
            InitializeComponent();
        }

        private void txtTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferType.SelectedIndex == 0)
            {
                radioInflow.Text = "Gelen Havale";
                radioOutflow.Text = "Giden Havale";
                ;
            }
            else
            {
                radioInflow.Text = "Gelen EFT";
                radioOutflow.Text = "Giden EFT";

            }
        }

        private void frmMoneyTranfer_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }

        void Clear()
        {
            txtAccountName.Text = "";
            txtAccountNo.Text = "";
            txtAmount.Text = "0";
            txtCurrentCode.Text = "";
            txtCurrentName.Text = "";
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtDescription.Text = "";
            txtDocumentNo.Text = "";
            Edit = false;
            BankID = -1;
            CurrentID = -1;
            ProcessID = -1;
            frmMain.Transfer = -1;
             
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
        void OpenCurrent(int ID)
        {
            try
            {
                CurrentID = ID;
                txtCurrentCode.Text = DB.TBL_Currents.First(s => s.ID == CurrentID).CurrentCode;
                txtCurrentName.Text = DB.TBL_Currents.First(s => s.ID == CurrentID).CurrentName;
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }
        void NewSave()
        {
            try
            {
                Functions.TBL_BANKMOVEMENT bank = new Functions.TBL_BANKMOVEMENT();
                bank.Amount = decimal.Parse(txtAmount.Text);
                bank.BankID = BankID;
                bank.CurrentID = CurrentID;
                bank.Description = txtDescription.Text;
                bank.DocumentNo = txtDocumentNo.Text;
                bank.DocumentType = txtTransferType.SelectedItem.ToString();
                if (radioInflow.Checked) bank.GCCode = "G";
                if (radioOutflow.Checked) bank.GCCode = "C";
                bank.Date = DateTime.Parse(txtDate.Text);
                bank.SaveDate = DateTime.Now;
                bank.SaveUser = frmMain.UserID;
                DB.TBL_BANKMOVEMENTs.InsertOnSubmit(bank);
                DB.SubmitChanges();
                Functions.TBL_CurrentMovement current = new Functions.TBL_CurrentMovement();
                current.Description = txtDescription.Text;
                if (radioInflow.Checked) current.Credit = decimal.Parse(txtAmount.Text);
                if (radioInflow.Checked) current.Debt = decimal.Parse(txtAmount.Text);
                current.CurrentID = CurrentID;
                current.DocumentID = bank.Id;
                current.DocumentType = txtTransferType.SelectedItem.ToString();
                current.Date = DateTime.Parse(txtDate.Text);
                if (txtTransferType.SelectedIndex == 0) current.Type = "BH";
                if (txtTransferType.SelectedIndex == 1) current.Type = "EFT";
                current.SaveDate = DateTime.Now;
                current.SaveUser = frmMain.UserID;
                DB.TBL_CurrentMovements.InsertOnSubmit(current);
                DB.SubmitChanges();
                messages.NewRecord("Para transfer kaydı işlendi.");
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
                Functions.TBL_BANKMOVEMENT bank = DB.TBL_BANKMOVEMENTs.First(s => s.Id == ProcessID);
                bank.Amount = decimal.Parse(txtAmount.Text);
                bank.BankID = BankID;
                bank.CurrentID = CurrentID;
                bank.Description = txtDescription.Text;
                bank.DocumentNo = txtDocumentNo.Text;
                bank.DocumentType = txtTransferType.SelectedItem.ToString();
                if (radioInflow.Checked) bank.GCCode = "G";
                if (radioOutflow.Checked) bank.GCCode = "C";
                bank.Date = DateTime.Parse(txtDate.Text);
                bank.EditDate = DateTime.Now;
                bank.EditUser = frmMain.UserID;

                DB.SubmitChanges();
                Functions.TBL_CurrentMovement current = DB.TBL_CurrentMovements.First(s => s.DocumentType == txtTransferType.SelectedItem.ToString() && s.DocumentID == ProcessID);
                current.Description = txtDescription.Text;
                if (radioInflow.Checked) current.Credit = decimal.Parse(txtAmount.Text);
                if (radioInflow.Checked) current.Debt = decimal.Parse(txtAmount.Text);
                current.CurrentID = CurrentID;
                current.DocumentID = bank.Id;
                current.DocumentType = txtTransferType.SelectedItem.ToString();
                current.Date = DateTime.Parse(txtDate.Text);
                if (txtTransferType.SelectedIndex == 0) current.Type = "BH";
                if (txtTransferType.SelectedIndex == 1) current.Type = "EFT";
                current.EditDate = DateTime.Now;
                current.EditUser = frmMain.UserID;

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
               DB.TBL_CurrentMovements.DeleteOnSubmit(DB.TBL_CurrentMovements.First(s=>s.DocumentType==txtTransferType.SelectedItem.ToString()&&s.DocumentID==ProcessID));
                DB.SubmitChanges();
                DB.TBL_BANKMOVEMENTs.DeleteOnSubmit(DB.TBL_BANKMOVEMENTs.First(s => s.Id == ProcessID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }
        public void Open(int ID)
        {
            try
            {
                Edit = true;
                ProcessID = ID;
                Functions.TBL_BANKMOVEMENT bank = DB.TBL_BANKMOVEMENTs.First(s => s.Id == ProcessID);
                OpenBank(bank.BankID.Value);
                OpenCurrent(bank.CurrentID.Value);
                txtDescription.Text = bank.Description;
                txtDocumentNo.Text = bank.DocumentNo;
                txtDate.Text = bank.Date.Value.ToShortDateString();
                txtTransferType.Text = bank.DocumentType;
                txtAmount.Text = bank.Amount.ToString();
                if (bank.GCCode == "G") radioInflow.Checked = true;
                if (bank.GCCode == "C") radioOutflow.Checked = true;
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        private void txtAccountName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = forms.BankList(true);
            if (ID > 0) OpenBank(ID);
            frmMain.Transfer = -1;
        }

        private void txtCurrentCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = forms.CurrentList(true);
            if (ID > 0) OpenCurrent(ID);
            frmMain.Transfer = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && CurrentID > 0 && BankID > 0 && ProcessID > 0 && messages.Update() == DialogResult.Yes) Update();
            else NewSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && CurrentID > 0 && BankID > 0 && ProcessID > 0 && messages.Delete() == DialogResult.Yes) Delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}