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
    public partial class frmCurrentList : DevExpress.XtraEditors.XtraForm
    {
        Functions.DbDataContext DB = new Functions.DbDataContext();
        public bool Selection = false;
        int SelectionID = -1;
       // bool Edit = false;

        public frmCurrentList()
        {
            InitializeComponent();
        }

        private void frmCurrentList_Load(object sender, EventArgs e)
        {
            Lists();
        }
        void Lists()
        {
            var list = from s in DB.TBL_Currents
                       where s.CurrentName.Contains(txtCurrentName.Text) && s.CurrentCode.Contains(txtCurrentCode.Text)
                       select s;
            gridList.DataSource = list;
        }
        void Select()
        {
            try
            {
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {
                SelectionID = -1;
            }
        }

        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            Select();
            if (Selection&&SelectionID>0)
            {
                frmMain.Transfer = SelectionID;
                this.Close();
            }
        }
    }
}