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

namespace PreAccountancy.Modul_Safe
{
    public partial class frmSafeMovement : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();


        int MovementsID = -1;
        int DocumentsID = -1;
        int SafeID = -1;
        string DocumentsType;
        public frmSafeMovement()
        {
            InitializeComponent();
        }

        private void frmSafeMovement_Load(object sender, EventArgs e)
        {

        }

        public void Open(int ID)
        {
            try
            {
                SafeID = ID;
                txtSafeCode.Text = DB.TBL_Safes.First(S => S.ID == SafeID).SafeCode;
                txtSafeName.Text = DB.TBL_Safes.First(S => S.ID == SafeID).SafeName;
                GetStatus();
                Lists();
            }
            catch (Exception e)
            {
                messages.Error(e);
            }
        }
        void GetStatus()
        {
            Functions.VW_SAFESTATUS sAFESTATUS = DB.VW_SAFESTATUS.First(s => s.SafeID == SafeID);
            txtIn.Text = sAFESTATUS.Inflow.Value.ToString();
            txtOut.Text = sAFESTATUS.Outflow.Value.ToString();
            txtBalance.Text = sAFESTATUS.Balance.Value.ToString();
        }
        void Lists()
        {
            var lst = from s in DB.VW_SAFEMOVEMENTs
                      where s.SafeID == SafeID
                      select s;
            gridControl1.DataSource = lst;
        }

        private void txtSafeCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = forms.SafeList(true);
            if (ID > 0)
            {
                Open(ID);
                frmMain.Transfer = -1;
            }
        }

        void Select()
        {
            MovementsID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            try
            {
                try
                {
                    DocumentsID = int.Parse(gridView1.GetFocusedRowCellValue("DocumentID").ToString());
                }
                catch (Exception)
                {
                    DocumentsID = -1;
                }
                DocumentsType = gridView1.GetFocusedRowCellValue("DocumentType").ToString();

            }
            catch (Exception)
            {
                MovementsID = -1;
                DocumentsID = -1;
                DocumentsType = "";
            }
        }
        private void rightClick_Opening(object sender, CancelEventArgs e)
        {
            Select();
            if(DocumentsType== "Kasa Devir Kartı")
            {
                SetTransferCard.Enabled = true;
                SetPayment.Enabled = false;
            }
            else if (DocumentsType== "Kasa Tahsilat"|| DocumentsType== "Kasa Ödeme")
            {
                SetTransferCard.Enabled = false;
                SetPayment.Enabled = true;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void SetTransferCard_Click(object sender, EventArgs e)
        {
            forms.SafeTransfer(true, MovementsID);
            Lists();
            GetStatus();
        }

        private void SetPayment_Click(object sender, EventArgs e)
        {
            forms.SafePayment(true, MovementsID);
            Lists();
            GetStatus();

        }
    }
}