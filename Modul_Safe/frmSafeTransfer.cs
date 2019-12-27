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
    public partial class frmSafeTransfer : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Forms forms = new Functions.Forms();

        bool Edit = false;
        int SafeID = -1;
        int ProcessID = -1;
        public frmSafeTransfer()
        {
            InitializeComponent();
        }

        private void frmSafeTransfer_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
        void Clear()
        {
            txtAmount.Text = "0.00";
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtDescription.Text = "";
            txtDocumentNo.Text = "";
            txtSafeCode.Text = "";
            txtSafeName.Text = "";
            Edit = false;
            SafeID = -1;
            ProcessID = -1;
            frmMain.Transfer = -1;
        }
       
        void NewSave()
        {
            try
            {
                Functions.TBL_SafeMovement movement = new Functions.TBL_SafeMovement();
                movement.Desciption = txtDescription.Text;
                movement.DocumentNo = txtDocumentNo.Text;
                movement.DocumentType = "Kasa Devir Kartı";
                if (radioOutside.Checked) movement.GCCode = "C";
                if (radioInside.Checked) movement.GCCode = "G";
                movement.SafeID = SafeID;
                movement.Date = DateTime.Parse(txtDate.Text);
                movement.Amount = decimal.Parse(txtAmount.Text);
                movement.SaveDate = DateTime.Now;
                movement.SaveUser = frmMain.UserID;
                DB.TBL_SafeMovements.InsertOnSubmit(movement);
                DB.SubmitChanges();
                messages.NewRecord("Devir Kartı Hareket Kaydı İşlenmiştir.");
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        new void Update()
        {
            try
            {
                Functions.TBL_SafeMovement movement = DB.TBL_SafeMovements.First(s => s.ID == ProcessID);
                movement.Desciption = txtDescription.Text;
                movement.DocumentNo = txtDocumentNo.Text;
                movement.DocumentType = "Kasa Devir Kartı";
                if (radioOutside.Checked) movement.GCCode = "C";
                if (radioInside.Checked) movement.GCCode = "G";
                movement.SafeID = SafeID;
                movement.Date = DateTime.Parse(txtDate.Text);
                movement.Amount = decimal.Parse(txtAmount.Text);
                movement.EditDate = DateTime.Now;
                movement.EditUser = frmMain.UserID;
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
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

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

                MessageBox.Show("Hata!");
            }
        }

        public void Open(int ID)
        {
            try
            {
                ProcessID = ID;
                Edit = true;
                
                Functions.TBL_SafeMovement movement = DB.TBL_SafeMovements.First(s => s.ID == ProcessID);
                txtAmount.Text = movement.Amount.ToString();
                txtDate.Text = movement.Date.Value.ToShortDateString();
                txtDescription.Text = movement.Desciption;
                txtDocumentNo.Text = movement.DocumentNo;
                OpenSafe(movement.SafeID.Value);
                if (movement.GCCode=="G")
                {
                    radioInside.Checked = true;
                }
                else
                {
                    radioOutside.Checked = true;
                }
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
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
    }
}