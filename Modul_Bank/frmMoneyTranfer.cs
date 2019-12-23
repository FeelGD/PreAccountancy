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
    public partial class frmMoneyTranfer : DevExpress.XtraEditors.XtraForm
    {
        string ProgressType = "Banka Havale";
        public frmMoneyTranfer()
        {
            InitializeComponent();
        }

        private void txtTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferType.SelectedIndex==0)
            {
                radioIncoming.Text = "Gelen Havale";
                radioOutgoing.Text = "Giden Havale";
                ProgressType = "Banka Havale";
;            }
            else
            {
                radioIncoming.Text = "Gelen EFT";
                radioOutgoing.Text = "Giden EFT";
                ProgressType = "Banka EFT";

            }
        }

        private void frmMoneyTranfer_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}