﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PreAccountancy
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Functions.Forms Forms = new Functions.Forms();

        public static int UserID = -1;
        public static int Transfer = -1;


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStockCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StockCard();
        }

        private void btnStockList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StockList();
        }

        private void btnStockGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StockGroup();
        }

        private void btnStockMovements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StockMovement();
        }
    }
}