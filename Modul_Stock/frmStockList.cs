﻿using System;
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

        public frmStockList()
        {
            InitializeComponent();
        }

        void Lists()
        {

        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            Lists();
        }
    }
}