using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAccountancy.Functions
{
    class Forms
    {
        public void StockList(bool Selection = false)
        {
            Modul_Stock.frmStockList frm = new Modul_Stock.frmStockList();

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
        }

        public void StockGroup(bool Selection = false)
        {
            Modul_Stock.frmStockGroup frm = new Modul_Stock.frmStockGroup();
            if (Selection) frm.Selection = Selection;
            
               
                frm.ShowDialog();
           
        }

        public void StockMovement(bool Open = false)
        {

        }
        public void StockCard(bool Open = false)
        {
            Modul_Stock.frmStockCard frm = new Modul_Stock.frmStockCard();
            frm.ShowDialog();
        }
    }
}
