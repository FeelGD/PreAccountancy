using System;
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


        public int CurrentGroup(bool Selection = false)
        {
            Modul_Current.frmCurrentGroup currentGroup = new Modul_Current.frmCurrentGroup();
            if (Selection) currentGroup.Selection = Selection;
            currentGroup.ShowDialog();
            return frmMain.Transfer;
        }

    }
}
