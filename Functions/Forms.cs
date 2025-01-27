﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAccountancy.Functions
{
    class Forms
    {
        #region StockForms
        public int StockList(bool Selection = false)
        {
            Modul_Stock.frmStockList stockList = new Modul_Stock.frmStockList();

            if (Selection)
            {
                stockList.Selection = Selection;
                stockList.ShowDialog();
            }
            else
            {
                stockList.MdiParent = frmMain.ActiveForm;
                stockList.Show();
            }
            return frmMain.Transfer;
        }

        public int StockGroup(bool Selection = false)
        {
            Modul_Stock.frmStockGroup stockGroup = new Modul_Stock.frmStockGroup();
            if (Selection) stockGroup.Selection = Selection;

            stockGroup.ShowDialog();
            return frmMain.Transfer;

        }

        public void StockMovement(bool Open = false)
        {

        }
        public void StockCard(bool Open = false)
        {
            Modul_Stock.frmStockCard stockCard = new Modul_Stock.frmStockCard();
            stockCard.ShowDialog();
        }
        #endregion

        #region CurrentForms
        public int CurrentGroup(bool Selection = false)
        {
            Modul_Current.frmCurrentGroup currentGroup = new Modul_Current.frmCurrentGroup();
            if (Selection) currentGroup.Selection = Selection;
            currentGroup.ShowDialog();
            return frmMain.Transfer;
        }

        public int CurrentList(bool Selection = false)
        {
            Modul_Current.frmCurrentList currentList = new Modul_Current.frmCurrentList();
            if (Selection)
            {
                currentList.Selection = Selection;
                currentList.ShowDialog();
            }
            else
            {
                currentList.MdiParent = frmMain.ActiveForm;
                currentList.Show();
            }
            return frmMain.Transfer;
        }
        public void CurrentOpeningCard(bool Open = false, int CurrentID = -1)
        {
            Modul_Current.frmCurrentOpeningCard openingCard = new Modul_Current.frmCurrentOpeningCard();
            if (Open) openingCard.Open(CurrentID);
            openingCard.ShowDialog();
        }
        #endregion

        #region SafeForms
        public void SafeOpeningCard()
        {
            Modul_Safe.frmSafeOpeningCard openingCard = new Modul_Safe.frmSafeOpeningCard();
            openingCard.ShowDialog();
        }
        public void SafeTransfer(bool Open = false, int ProcessID = -1)
        {
            Modul_Safe.frmSafeTransfer transfer = new Modul_Safe.frmSafeTransfer();
            if (Open) transfer.Open(ProcessID);
            transfer.ShowDialog();
        }
        public int SafeList(bool Selection = false)
        {
            Modul_Safe.frmSafeList list = new Modul_Safe.frmSafeList();
            if (Selection)
            {
                list.Selection = Selection;
                list.ShowDialog();
            }
            else
            {
                list.MdiParent = frmMain.ActiveForm;
                list.Show();
            }
            return frmMain.Transfer;
        }
        public void SafePayment(bool Open = false, int ID = -1)
        {
            Modul_Safe.frmSafePayment safePayment = new Modul_Safe.frmSafePayment();
            if (Open) safePayment.Open(ID);
            safePayment.ShowDialog();
        }
        public void SafeMovement(bool Open = false, int ID = -1)
        {
            Modul_Safe.frmSafeMovement safeMovement = new Modul_Safe.frmSafeMovement();
            safeMovement.MdiParent = frmMain.ActiveForm;
            if (Open) safeMovement.Open(ID);
            safeMovement.Show();
        }
        #endregion

        #region BankForms
        public void BankOpeningCard()
        {
            Modul_Bank.frmBankOpeningCard bankOpeningCard = new Modul_Bank.frmBankOpeningCard();
            bankOpeningCard.ShowDialog();
        }
        public void BankProcess(bool Open = false, int ID = -1)
        {
            Modul_Bank.frmBankProcess frm = new Modul_Bank.frmBankProcess();
            if (Open) frm.Open(ID);
            frm.ShowDialog();
        }
        public int BankList(bool Selection = false)
        {
            Modul_Bank.frmBankList frm = new Modul_Bank.frmBankList();
            if (Selection)
            {
                frm.Selection = Selection;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = frmMain.ActiveForm;
                frm.Show();
            }
            return frmMain.Transfer;
        }
        public void BankTransfer(bool Open = false, int ID = -1)
        {
            Modul_Bank.frmMoneyTranfer frm = new Modul_Bank.frmMoneyTranfer();
            if (Open) frm.Open(ID);
            frm.ShowDialog();
        }
        public void BankMovement(bool Open = false, int ID = -1)
        {
            Modul_Bank.frmBankMovement frm = new Modul_Bank.frmBankMovement();
            frm.MdiParent = frmMain.ActiveForm;
            if (Open) frm.OpenBank(ID);
            frm.Show();
        } 
        #endregion

        public void Invoice(bool Open=false, int ID = -1)
        {
            Modul_Invoice.frmSalesInvoice frm;
            if (Open)
            {
                frm = new Modul_Invoice.frmSalesInvoice(Open,ID);
            }
            else
            {
                frm = new Modul_Invoice.frmSalesInvoice();
            }
            frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
        }

    }
}
