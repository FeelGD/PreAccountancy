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

namespace PreAccountancy.Modul_Bank
{
    public partial class frmBankList : DevExpress.XtraEditors.XtraForm
    {
        public bool Selection = false;
        int SelectionID = -1;
        public frmBankList()
        {
            InitializeComponent();
        }

        private void frmBankList_Load(object sender, EventArgs e)
        {
            Lists();
        }
        void Lists()
        {

        }
    }
}