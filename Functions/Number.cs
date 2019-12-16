﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAccountancy.Functions
{
    class Number
    {
        DbDataContext DB = new DbDataContext();
        Messages Messages = new Messages();


        public string StockCodeNumber()
        {
            try
            {
                int Number = int.Parse((from s in DB.TBL_Stocks orderby s.ID descending select s).First().StockCode);
                Number++;
                string Num = Number.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception EX)
            {

                Messages.Error(EX);
                return "0000001";
            }
        }
    }
}