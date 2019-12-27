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
    public partial class frmCurrentGroup : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages Messages = new Functions.Messages();

        public bool Selection = false;
        bool Edit = false;
        int SelectionID = -1;

        public frmCurrentGroup()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtGroupCode.Text = "";
            txtGroupName.Text = "";
            Edit = false;
            SelectionID = -1;
            Lists();

        }
        void Lists()
        {
            var list = from s in DB.TBL_CurrentGroups
                       select s;
            gridList.DataSource = list;
        }
        void NewSave()
        {
            try
            {
                Functions.TBL_CurrentGroup group = new Functions.TBL_CurrentGroup();
                group.CurrentGroupName = txtGroupName.Text;
                group.CurrentGroupCode = txtGroupCode.Text;
                group.CurrentGroupSaveDate = DateTime.Now;
                group.CurrentGroupSaveUser = frmMain.UserID;
                DB.TBL_CurrentGroups.InsertOnSubmit(group);
                DB.SubmitChanges();
                Messages.NewRecord("Yeni cari grup kayı oluşturuldu.");
                Clear();

            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }

        new void Update()
        {
            try
            {
                Functions.TBL_CurrentGroup group = DB.TBL_CurrentGroups.First(s => s.ID == SelectionID);
                group.CurrentGroupName = txtGroupName.Text;
                group.CurrentGroupCode = txtGroupCode.Text;
                group.CurrentGroupEditDate = DateTime.Now;
                group.CurrentGroupEditUser = frmMain.UserID;
                DB.SubmitChanges();
                Messages.Update(true);
                Clear();
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }
        new void Select()
        {
            try
            {
                Edit = true;
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("CurrentGroupName").ToString();
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("CurrentGroupCode").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SelectionID = -1;
            }
        }
        void Delete()
        {
            try
            {
                DB.TBL_CurrentGroups.DeleteOnSubmit(DB.TBL_CurrentGroups.First(s => s.ID == SelectionID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                Messages.Error(e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && Messages.Update() == DialogResult.Yes)
            {
                Update();
            }
            else
            {
                NewSave();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && Messages.Delete() == DialogResult.Yes) Delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrentGroup_Load(object sender, EventArgs e)
        {
            Lists();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Select();
            if (Selection && SelectionID > 0)
            {
                frmMain.Transfer = SelectionID;
                this.Close();
            }
        }
    }
}