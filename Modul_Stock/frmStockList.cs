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

namespace PreAccountancy.Modul_Stock
{
    public partial class frmStockList : DevExpress.XtraEditors.XtraForm
    {



        public bool Selection = false;
        int SelectionID = -1;
        Functions.DbDataContext DB = new Functions.DbDataContext();

        public frmStockList()
        {
            InitializeComponent();
        }

        void Lists()
        {
            var list = from s in DB.TBL_Stocks
                       where s.StockName.Contains(txtStockName.Text) && s.StockBarcode.Contains(txtBarcode.Text) && s.StockCode.Contains(txtStockCode.Text)
                       select s;
            gridList.DataSource = list;
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            Lists();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Lists();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStockCode.Text = "";
            txtBarcode.Text = "";
            txtStockName.Text = "";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
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