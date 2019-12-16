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

        Functions.Db DB = new Functions.Db();


        public bool Selection = false;
        

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
            var list = from s in DB.TBL_StockGroup
                       select s;
            gridList.DataSource = list;

        }

        void Clear()
        {
            txtGroupCode.Text = "";
            txtGroupName.Text = "";
            
        }
        void NewRecord()
        {
            
            
        }

    }
}