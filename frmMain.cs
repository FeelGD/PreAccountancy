using System;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Caption = DateTime.Now.ToString();
        }
        public void Message(string Header, string Message)
        {
            alertControl.Show(this, Header, Message);
        }


        #region Stock
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
        private void navStockCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.StockCard();
        }

        private void navStockList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.StockList();
        }

        private void navStockGroup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.StockGroup();
        }

        private void navStockMovement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.StockMovement();
        }
        #endregion

        #region Current
        private void barbtnCurrentOpeningCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.CurrentOpeningCard();
        }

        private void barbtnCurrentGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.CurrentGroup();
        }

        private void barbtnCurrentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barbtnCurrentMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void navCurrentList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.CurrentList();
        }

        private void navCurrentGroups_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.CurrentGroup();
        }

        private void navCurrentOpeningCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.CurrentOpeningCard();
        }

        private void navCurrentMovement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        #endregion

        #region Safe
        private void barbtnSafeOpeningCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SafeOpeningCard();
        }

        private void barbtnSafeTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SafeTransfer();
        }

        private void barbtnSafeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SafeList();
        }

        private void barbtnSafePayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SafePayment();
        }

        private void barbtnSafeMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SafeMovement();
        }
        private void navSafePayment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SafePayment();
        }

        private void navSafeTransfer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SafeTransfer();
        }

        private void navSafeMovement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SafeMovement();
        }

        private void navSafeOpeningCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SafeOpeningCard();
        }

        private void navSafeList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SafeList();
        }
        #endregion

        #region Bank
        private void barbtnBankOpeningCard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.BankOpeningCard();
        }

        private void barbtnBankProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.BankProcess();
        }

        private void barbtnBankList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.BankList();
        }

        private void barbtnMoneyTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.BankTransfer();
        }

        private void barbtnBankMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.BankMovement();
        }
        private void navBankProcess_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.BankProcess();
        }

        private void navBankList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.BankList();
        }

        private void navBankTransfer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.BankTransfer();
        }

        private void navBankOpeningCard_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.BankOpeningCard();
        }

        private void navBankMovement_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.BankMovement();
        }

        #endregion

        private void barbtnSalesInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Invoice();
        }
    }
}
