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

namespace PreAccountancy.Modul_Current
{
    public partial class frmCurrentOpeningCard : DevExpress.XtraEditors.XtraForm
    {

        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages Messages = new Functions.Messages();
        Functions.Number Numbers = new Functions.Number();
        Functions.Forms Forms = new Functions.Forms();
        Functions.Photos Photos = new Functions.Photos();

        bool Edit = false;
        bool SelectedPhoto = false;
        int CurrentID = -1;
        int GroupID = -1;


        public frmCurrentOpeningCard()
        {
            InitializeComponent();
        }

        private void frmCurrentOpeningCard_Load(object sender, EventArgs e)
        {
            txtCurrentCode.Text = Numbers.CurrentCodeNumber();
        }

        void Clear()
        {
            foreach (Control item in groupControl1.Controls)
                if (item is DevExpress.XtraEditors.TextEdit || item is DevExpress.XtraEditors.ButtonEdit) item.Text = "";
            foreach (Control items in groupControl2.Controls)
                if (items is DevExpress.XtraEditors.TextEdit || items is DevExpress.XtraEditors.ButtonEdit || items is DevExpress.XtraEditors.MemoEdit) items.Text = "";
            txtCurrentCode.Text = Numbers.CurrentCodeNumber();
            Edit = false;
            CurrentID = -1;
            GroupID = -1;
            frmMain.Transfer = -1;
        }

        void NewSave()
        {
            try
            {
                Functions.TBL_Current current = new Functions.TBL_Current();
                current.CurrentAddress = txtAddress.Text;
                current.CurrentAuthorized1 = txtAuthorized1.Text;
                current.CurrentAuthorized1Mail = txtAuthorized1Mail.Text;
                current.CurrentAuthorized2 = txtAuthorized2.Text;
                current.CurrentAuthorized2Mail = txtAuthorized2Mail.Text;
                current.CurrentCity = txtCity.Text;
                current.CurrentCode = txtCurrentCode.Text;
                current.CurrentCountry = txtCountry.Text;
                current.CurrentDistrict = txtDistrict.Text;
                current.CurrentGroupID = GroupID;
                current.CurrentMailInfo = txtMailInfo.Text;
                current.CurrentName = txtCurrentName.Text;
                current.CurrentPhone1 = txtPhone1.Text;
                current.CurrentPhone2 = txtPhone2.Text;
                current.CurrentFax1 = txtFax1.Text;
                current.CurrentFax2 = txtFax2.Text;
                current.CurrentTaxNumber = txtTaxNumber.Text;
                current.CurrentTaxOffice = txtTaxOffice.Text;
                current.CurrentWebAddress = txtWebAddress.Text;
                current.CurrentSaveDate = DateTime.Now;
                current.CurrentSaveUser = frmMain.UserID;
                DB.TBL_Currents.InsertOnSubmit(current);
                DB.SubmitChanges();
                Messages.NewRecord("Yeni Cari Kaydı Oluşturuldu.");
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
                Functions.TBL_Current current = DB.TBL_Currents.First(s => s.ID == CurrentID);
                current.CurrentAddress = txtAddress.Text;
                current.CurrentAuthorized1 = txtAuthorized1.Text;
                current.CurrentAuthorized1Mail = txtAuthorized1Mail.Text;
                current.CurrentAuthorized2 = txtAuthorized2.Text;
                current.CurrentAuthorized2Mail = txtAuthorized2Mail.Text;
                current.CurrentCity = txtCity.Text;
                current.CurrentCode = txtCurrentCode.Text;
                current.CurrentCountry = txtCountry.Text;
                current.CurrentDistrict = txtDistrict.Text;
                current.CurrentGroupID = GroupID;
                current.CurrentMailInfo = txtMailInfo.Text;
                current.CurrentName = txtCurrentName.Text;
                current.CurrentPhone1 = txtPhone1.Text;
                current.CurrentPhone2 = txtPhone2.Text;
                current.CurrentFax1 = txtFax1.Text;
                current.CurrentFax2 = txtFax2.Text;
                current.CurrentTaxNumber = txtTaxNumber.Text;
                current.CurrentTaxOffice = txtTaxOffice.Text;
                current.CurrentWebAddress = txtWebAddress.Text;
                current.CurrentEditDate = DateTime.Now;
                current.CurrentEditUser = frmMain.UserID;
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
                DB.TBL_Currents.DeleteOnSubmit(DB.TBL_Currents.First(s => s.ID == CurrentID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }
       
        public void Open(int ID)
        {
            try
            {
                Edit = true;
                CurrentID = ID;
                Functions.TBL_Current current = DB.TBL_Currents.First(s => s.ID == CurrentID);
                txtAddress.Text = current.CurrentAddress;
                txtAuthorized1.Text = current.CurrentAuthorized1;
                txtAuthorized2.Text = current.CurrentAuthorized2;
                txtAuthorized2Mail.Text = current.CurrentAuthorized2Mail;
                txtAuthorized1Mail.Text = current.CurrentAuthorized1Mail;
                txtCity.Text = current.CurrentCity;
                txtCountry.Text = current.CurrentCountry;
                txtCurrentCode.Text = current.CurrentCode;
                txtCurrentName.Text = current.CurrentName;
                txtDistrict.Text = current.CurrentDistrict;
                txtFax1.Text = current.CurrentFax1;
                txtFax2.Text = current.CurrentFax2;
                txtMailInfo.Text = current.CurrentMailInfo;
                txtPhone1.Text = current.CurrentPhone1;
                txtPhone2.Text = current.CurrentPhone2;
                txtTaxNumber.Text = current.CurrentTaxNumber;
                txtTaxOffice.Text = current.CurrentTaxOffice;
                txtWebAddress.Text = current.CurrentWebAddress;
                OpenGroup(current.CurrentGroupID.Value);
                
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        } 
        void OpenGroup(int ID)
        {
            try
            {
                GroupID = ID;
                Functions.TBL_CurrentGroup currentGroup = DB.TBL_CurrentGroups.First(s => s.ID == GroupID);
                txtCurrentGroupName.Text = currentGroup.CurrentGroupCode;
                txtCurrentGroupCode.Text = currentGroup.CurrentGroupName;
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && CurrentID > 0 && Messages.Delete() == DialogResult.Yes) Delete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && CurrentID > 0 && Messages.Update() == DialogResult.Yes) Update();
            else NewSave();
        }

        private void txtCurrentGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Forms.CurrentGroup(true);
            if (ID>0)
            {
                OpenGroup(ID);
            }
            frmMain.Transfer = -1;
        }

        private void txtCurrentCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Forms.CurrentList(true);
            if (ID>0)
            {
                Open(ID);
            }
            frmMain.Transfer = -1;
        }
    }
}