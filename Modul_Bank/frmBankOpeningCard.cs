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
    public partial class frmBankOpeningCard : DevExpress.XtraEditors.XtraForm
    {


        bool Edit = false;
        int SelectionID = -1;



        public frmBankOpeningCard()
        {
            InitializeComponent();
        }

        private void frmBankOpeningCard_Load(object sender, EventArgs e)
        {

        }
    }
}