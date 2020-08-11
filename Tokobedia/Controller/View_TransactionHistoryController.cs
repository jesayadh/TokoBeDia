using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_TransactionHistoryController
    {
        public static List<DetailTransaction> listTransactionHistory(int userID)
        {
            return View_TransactionHistoryHandler.listTransactionHistory(userID);
        }

        public static int getUserID(object user)
        {
            return View_TransactionHistoryHandler.getUserID(user);
        }

        public static int getSubTotal(List<DetailTransaction> list)
        {
            int price = 0;
            foreach(DetailTransaction dt in list)
            {
                price += dt.Product.Price;
            }
            return price;
        }

    }
}