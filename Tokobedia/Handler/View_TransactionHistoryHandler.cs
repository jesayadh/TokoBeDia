using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_TransactionHistoryHandler
    {
        public static List<DetailTransaction> listTransactionHistory(int userID)
        {
            var produk = DetailTransactionRepository.getTransactionList(userID);
            return produk;
        }

        public static int getUserID(object user)
        {
            User u = (User)user;
            var tempUser = UserRepository.getCurrent(u.UserID);
            return tempUser.UserID;
        }

        public static int getPrice(int productID)
        {
            Product u = ProductRepository.getSingleProductByID(productID);
            return u.Price;
        }

    }
}