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
using System.Linq;

namespace PreAccountancy.Modul_Stock
{
    public partial class frmStockGroup : DevExpress.XtraEditors.XtraForm
    {

        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages Messages = new Functions.Messages();

        public bool Selection = false;
        int SelectionID = -1;
        bool Edit = false;

        public frmStockGroup()
        {
            InitializeComponent();
        }

        private void frmStockGroup_Load(object sender, EventArgs e)
        {
            Lists();
        }
        void Lists()
        {
            var list = from s in DB.TBL_StockGroups
                       select s;
            gridList.DataSource = list;

        }

        void Clear()
        {
            txtGroupCode.Text = "";
            txtGroupName.Text = "";
            Edit = false;
            Lists();

        }
        void NewRecord()
        {
            try
            {
                Functions.TBL_StockGroup Add = new Functions.TBL_StockGroup();
                Add.GroupCode = txtGroupCode.Text;
                Add.GroupName = txtGroupName.Text;
                Add.GroupSaveDate = DateTime.Now;
                Add.GroupSaveUser = frmMain.UserID;
                DB.TBL_StockGroups.InsertOnSubmit(Add);
                DB.SubmitChanges();
                Messages.NewRecord("Yeni Kayıt Oluşturuldu.");
                Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("deneme");
                Messages.Error(e);
            }


        }

        new void Update()
        {
            try
            {
                Functions.TBL_StockGroup Group = DB.TBL_StockGroups.First(s => s.ID == SelectionID);
                Group.GroupCode = txtGroupCode.Text;
                Group.GroupName = txtGroupName.Text;
                Group.GroupEditUser = frmMain.UserID;
                Group.GroupEditDate = DateTime.Now;
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
            DB.TBL_StockGroups.DeleteOnSubmit(DB.TBL_StockGroups.First(s => s.ID == SelectionID));
            DB.SubmitChanges();
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && Messages.Delete() == DialogResult.Yes) Delete();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit && SelectionID > 0 && Messages.Update() == DialogResult.Yes)  Update();
            
            else NewRecord();
          
        }

        new void Select()
        {

            try
            {
                Edit = true;
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
                txtGroupCode.Text = gridView1.GetFocusedRowCellValue("GroupCode").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SelectionID = -1;
            }
        }

        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            Select();
            if (Selection && SelectionID > 0) frmMain.Transfer = SelectionID;
            this.Close();

        }
    }
}