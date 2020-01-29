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
    public partial class frmSafePayment : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();


        bool Edit = false;
        int ProcessID = -1;
        int CurrentMovementID = -1;
        int SafeID = -1;
        int CurrentID = -1;
        public frmSafePayment()
        {
            InitializeComponent();
        }

        private void frmSafePayment_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtProcessType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void Clear()
        {
            txtAmount.Text = "0";
            txtCurrentCode.Text = "";
            txtCurrentName.Text = "";
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtDescription.Text = "";
            txtDocumentNo.Text = "";
            txtProcessType.SelectedIndex = 0;
            txtSafeCode.Text = "";
            txtSafeName.Text = "";
            Edit = false;
            ProcessID = -1;
            SafeID = -1;
            CurrentID = -1;
            CurrentMovementID = -1;
            frmMain.Transfer = -1;

        }
        public void Open(int MovementID)
        {
            try
            {
                Edit = true;
                ProcessID = MovementID;
                Functions.TBL_SafeMovement safeMovement = DB.TBL_SafeMovements.First(s => s.ID == ProcessID);
                CurrentMovementID = DB.TBL_CurrentMovements.First(s => s.DocumentType == safeMovement.DocumentType && s.DocumentID == ProcessID).ID;
                MessageBox.Show("Cari Hareket ID : " + CurrentMovementID.ToString());
                txtDescription.Text = safeMovement.Desciption;
                txtDocumentNo.Text = safeMovement.DocumentNo;
                if (safeMovement.DocumentType == "Kasa Tahsilat") txtProcessType.SelectedIndex = 0;
                if (safeMovement.DocumentType == "Kasa Ödeme") txtProcessType.SelectedIndex = 1;
                txtDate.Text = safeMovement.Date.Value.ToShortDateString();
                txtAmount.Text = safeMovement.Amount.Value.ToString();
                OpenSafe(safeMovement.SafeID.Value);
                OpenCurrent(safeMovement.CurrentID.Value);


            }
            catch (Exception e)
            {
                Clear();
                messages.Error(e);
            }
        }
        void OpenSafe(int ID)
        {
            try
            {
                SafeID = ID;
                txtSafeName.Text = DB.TBL_Safes.First(s => s.ID == SafeID).SafeName;
                txtSafeCode.Text = DB.TBL_Safes.First(s => s.ID == SafeID).SafeCode;
            }
            catch (Exception)
            {
                SafeID = -1;
                MessageBox.Show("Hata!");
            }
        }
        void OpenCurrent(int ID)
        {
            try
            {
                CurrentID = ID;
                txtCurrentName.Text = DB.TBL_Currents.First(s => s.ID == CurrentID).CurrentName;
                txtCurrentCode.Text = DB.TBL_Currents.First(s => s.ID == CurrentID).CurrentCode;
            }
            catch (Exception)
            {
                CurrentID = -1;
                MessageBox.Show("Hata!");
            }
        }
        void newSave()
        {
            try
            {
                Functions.TBL_SafeMovement safeMovement = new Functions.TBL_SafeMovement();
                safeMovement.Desciption = txtDescription.Text;
                safeMovement.DocumentNo = txtDocumentNo.Text;
                safeMovement.CurrentID = CurrentID;
                safeMovement.DocumentType = txtProcessType.SelectedItem.ToString();

                if (txtProcessType.SelectedIndex == 0) safeMovement.GCCode = "G";

                if (txtProcessType.SelectedIndex == 1) safeMovement.GCCode = "C";

                safeMovement.SafeID = SafeID;
                safeMovement.SaveUser = frmMain.UserID;
                safeMovement.SaveDate = DateTime.Now;
                safeMovement.Date = DateTime.Parse(txtDate.Text);
                safeMovement.Amount = decimal.Parse(txtAmount.Text);
                DB.TBL_SafeMovements.InsertOnSubmit(safeMovement);
                DB.SubmitChanges();
                messages.NewRecord(txtProcessType.SelectedItem.ToString() + " yeni kasa hareketi olarak işlenmiştir.");
                Functions.TBL_CurrentMovement currentMovement = new Functions.TBL_CurrentMovement();
                currentMovement.Description = txtDocumentNo.Text + "Belge numaralı " + txtProcessType.SelectedItem.ToString() + "işlemi";
                if (txtProcessType.SelectedIndex == 0) currentMovement.Credit = decimal.Parse(txtAmount.Text);

                if (txtProcessType.SelectedIndex == 1) currentMovement.Debt = decimal.Parse(txtAmount.Text);
                currentMovement.CurrentID = CurrentID;
                currentMovement.DocumentID = safeMovement.ID;
                currentMovement.DocumentType = txtProcessType.SelectedItem.ToString();
                currentMovement.Date = DateTime.Parse(txtDate.Text);

                if (txtProcessType.SelectedIndex == 0) currentMovement.Type = "KT";

                if (txtProcessType.SelectedIndex == 1) currentMovement.Type = "KÖ";
                currentMovement.SaveDate = DateTime.Now;
                currentMovement.SaveUser = frmMain.UserID;
                DB.TBL_CurrentMovements.InsertOnSubmit(currentMovement);
                DB.SubmitChanges();
                messages.NewRecord(txtProcessType.SelectedItem.ToString() + " yeni cari hareketi olarak işlenmiştir.");
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
                Functions.TBL_SafeMovement safeMovement = DB.TBL_SafeMovements.First(s => s.ID == ProcessID);

                safeMovement.Desciption = txtDescription.Text;
                safeMovement.DocumentNo = txtDocumentNo.Text;
                safeMovement.CurrentID = CurrentID;
                safeMovement.DocumentType = txtProcessType.SelectedItem.ToString();

                if (txtProcessType.SelectedIndex == 0) safeMovement.GCCode = "G";

                if (txtProcessType.SelectedIndex == 1) safeMovement.GCCode = "C";

                safeMovement.SafeID = SafeID;
                safeMovement.EditUser = frmMain.UserID;
                safeMovement.EditDate = DateTime.Now;
                safeMovement.Date = DateTime.Parse(txtDate.Text);
                safeMovement.Amount = decimal.Parse(txtAmount.Text);
                DB.SubmitChanges();
                messages.Update(true);
                Functions.TBL_CurrentMovement currentMovement = DB.TBL_CurrentMovements.First(s => s.ID == CurrentMovementID);

                currentMovement.Description = txtDocumentNo.Text + "Belge numaralı " + txtProcessType.SelectedItem.ToString() + " işlemi";
                if (txtProcessType.SelectedIndex == 0) currentMovement.Credit = decimal.Parse(txtAmount.Text);

                if (txtProcessType.SelectedIndex == 1) currentMovement.Debt = decimal.Parse(txtAmount.Text);
                currentMovement.CurrentID = CurrentID;
                currentMovement.DocumentID = safeMovement.ID;
                currentMovement.DocumentType = txtProcessType.SelectedItem.ToString();
                currentMovement.Date = DateTime.Parse(txtDate.Text);

                if (txtProcessType.SelectedIndex == 0) currentMovement.Type = "KT";

                if (txtProcessType.SelectedIndex == 1) currentMovement.Type = "KÖ";
                currentMovement.EditDate = DateTime.Now;
                currentMovement.EditUser = frmMain.UserID;
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
                DB.TBL_SafeMovements.DeleteOnSubmit(DB.TBL_SafeMovements.First(s => s.ID == ProcessID));
                DB.TBL_CurrentMovements.DeleteOnSubmit(DB.TBL_CurrentMovements.First(s => s.ID == CurrentMovementID));
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        private void txtSafeCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = forms.SafeList(true);
            if (Id > 0)
            {
                OpenSafe(Id);
                frmMain.Transfer = -1;
            }
        }

        private void txtCurrentCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = forms.CurrentList(true);
                if (Id > 0)
            {
                OpenCurrent(Id);
                frmMain.Transfer = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && ProcessID > 0 && CurrentMovementID > 0 && messages.Update() == DialogResult.Yes) Update();
            else newSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && ProcessID > 0 && CurrentMovementID > 0 && messages.Delete() == DialogResult.Yes) Delete();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}