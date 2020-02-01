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
        Functions.DbDataContext DB = new Functions.DbDataContext();
        Functions.Messages messages = new Functions.Messages();
        Functions.Number number = new Functions.Number();

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
            var lst = from s in DB.VW_BANKLISTs
                      where s.AccountName.Contains(txtAccountName.Text) && s.AccountNo.Contains(txtAccountNo.Text) && s.IBAN.Contains(txtIBAN.Text)
                      select s;
            gridList.DataSource=lst;
        }
        void Select()
        {
            try
            {
                SelectionID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                Selection = true;
            }
            catch (Exception )
            {

                SelectionID = -1;
            }
        }

        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            Select();
            if (Selection && SelectionID > 0)
            {
                frmMain.Transfer = SelectionID;
                this.Close();
            }
        }
    }
}