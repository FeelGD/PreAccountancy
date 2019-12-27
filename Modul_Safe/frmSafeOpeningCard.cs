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
    public partial class frmSafeOpeningCard : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Number number = new Functions.Number();

        bool Edit = false;
        int SelectionID = -1;
        public frmSafeOpeningCard()
        {
            InitializeComponent();
        }

        private void frmSafeOpeningCard_Load(object sender, EventArgs e)
        {
            txtSafeCode.Text = number.SafeCodeNumber();
            Lists();
        }
        void Clear()
        {
            txtDescription.Text = "";
            txtSafeCode.Text = number.SafeCodeNumber();
            txtSafeName.Text = "";
            Edit = false;
            SelectionID = -1;
            Lists();
        }
        void NewSave()
        {
            try
            {
                Functions.TBL_Safe safe = new Functions.TBL_Safe();
                safe.Description = txtDescription.Text;
                safe.SafeName = txtSafeName.Text;
                safe.SafeCode = txtSafeCode.Text;
                safe.SaveUser = frmMain.UserID;
                safe.SaveDate = DateTime.Now;
                DB.TBL_Safes.InsertOnSubmit(safe);
                DB.SubmitChanges();
                messages.NewRecord("Yeni kasa kaydı oluşturulmuştur...");
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
                Functions.TBL_Safe safe = DB.TBL_Safes.First(s => s.ID == SelectionID);
                safe.Description = txtDescription.Text;
                safe.SafeName = txtSafeName.Text;
                safe.SafeCode = txtSafeCode.Text;
                safe.EditUser = frmMain.UserID;
                safe.EditDate = DateTime.Now;
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
                DB.TBL_Safes.DeleteOnSubmit(DB.TBL_Safes.First(s => s.ID == SelectionID));
                DB.SubmitChanges();
                Clear();
            }
            catch (Exception e)
            {

                messages.Error(e);
            }
        }

        new void Select()
        {
            try
            {
                Edit = true;
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtDescription.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
                txtSafeCode.Text = gridView1.GetFocusedRowCellValue("SafeCode").ToString();
                txtSafeName.Text = gridView1.GetFocusedRowCellValue("SafeName").ToString();
               // MessageBox.Show(SelectionID.ToString());

            }
            catch (Exception)
            {
                Edit = false;
                SelectionID = -1;
            }
        }
        void Lists()
        {
            var list = from s in DB.TBL_Safes
                       select s;
            gridControl1.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SelectionID.ToString());
            //MessageBox.Show(Edit.ToString());
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}