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
    public partial class frmBankMovement : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();

        int BankID = -1;
        int ProcessID = -1;
        string Document;

        public frmBankMovement()
        {
            InitializeComponent();
        }

        private void frmBankMovement_Load(object sender, EventArgs e)
        {

        }
        void Lists()
        {
            var lst = from s in DB.VW_BANKMOVEMENTs
                      where BankID == BankID
                      select s;
            list.DataSource = lst;
        }
        public void OpenBank(int ID)
        {
            try
            {
                BankID = ID;
                Functions.VW_BANKLIST bank = DB.VW_BANKLISTs.First(s => s.Id == BankID);

                txtAccountName.Text = bank.AccountName;
                txtAccountNo.Text = bank.AccountNo;
                txtInflow.Text = bank.Inflow.Value.ToString();
                txtOutflow.Text = bank.Outflow.Value.ToString();
                txtBalance.Text = bank.Balance.Value.ToString();
                Lists();
            }
            catch (Exception e)
            {
                messages.Error(e);
                throw;
            }
        }

        private void txtAccountName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = forms.BankList(true);
            if (ID > 0) OpenBank(ID);
            frmMain.Transfer = -1;
        }
        void Selection()
        {
            try
            {
                ProcessID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                Document = gridView1.GetFocusedRowCellValue("DocumentType").ToString();
            }
            catch (Exception)
            {
                ProcessID = -1;
                Document = "";
            }
        }
        private void rightClick_Opening(object sender, CancelEventArgs e)
        {
            Selection();
            if (ProcessID>0)
            {
                if (Document == "Banka İşlemi")
                {
                    SetBankProcess.Enabled = true;
                    SetBankTransfer.Enabled = false;
                }
                else if (Document == "Banka EFT" || Document == "Banka Havale")
                {
                    SetBankProcess.Enabled = false;
                    SetBankTransfer.Enabled = true;
                } 
            }
        }

        private void SetBankProcess_Click(object sender, EventArgs e)
        {
            forms.BankProcess(true, ProcessID);
            Lists();
        }

        private void SetBankTransfer_Click(object sender, EventArgs e)
        {
            forms.BankTransfer(true, ProcessID);
            Lists();
        }
    }
}