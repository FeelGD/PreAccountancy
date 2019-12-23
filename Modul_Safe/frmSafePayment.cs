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
    public partial class frmSafePayment : DevExpress.XtraEditors.XtraForm
    {

        bool Edit = false;
        int ProcessID = -1;
        string ProcessType = "Kasa Tahsilat";
        public frmSafePayment()
        {
            InitializeComponent();
        }

        private void frmSafePayment_Load(object sender, EventArgs e)
        {

        }

        private void txtProcessType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessType = txtProcessType.SelectedItem.ToString();
        }
    }
}