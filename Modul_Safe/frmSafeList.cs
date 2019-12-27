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
    public partial class frmSafeList : DevExpress.XtraEditors.XtraForm
    {

        Functions.DbDataContext DB = new Functions.DbDataContext();
        int SelectionID = -1;
        public bool Selection = false;

        public frmSafeList()
        {
            InitializeComponent();
        }

        private void frmSafeList_Load(object sender, EventArgs e)
        {
            Lists();
        }
        void Lists()
        {
            var list = from s in DB.TBL_Safes
                       where s.SafeCode.Contains(txtSafeCode.Text) && s.SafeName.Contains(txtSafeName.Text)
                       select s;
            gridList.DataSource = list;

        }
        new void Select()
        {
            try
            {
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {

                SelectionID = -1;
            }
        }

        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            Select();
            if (Selection && SelectionID > 0)
            {
                frmMain.Transfer = SelectionID;
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Lists();
        }
    }
}