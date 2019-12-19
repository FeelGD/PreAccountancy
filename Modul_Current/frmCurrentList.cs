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

        }
    }
}