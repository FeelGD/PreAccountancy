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
    public partial class frmSafeTransfer : DevExpress.XtraEditors.XtraForm
    {
        public frmSafeTransfer()
        {
            InitializeComponent();
        }

        private void frmSafeTransfer_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}