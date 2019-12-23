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

        }
    }
}