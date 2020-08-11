using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Factory;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class DetailTransactionRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();

        public static DetailTransaction searchProductInDetailTransaction(int ProductID)
        {
            return db.DetailTransactions.Where(x => x.ProductID == ProductID).FirstOrDefault(); 
        }

        public static List<DetailTransaction> getTransactionList(int userID)
        {
            if (UserRepository.getUserRoleID(userID) == 1)
                return db.DetailTransactions.ToList();
            else
                return db.DetailTransactions.Where(a => a.HeaderTransaction.UserID == userID).ToList();
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionId)
        {
            List<DetailTransaction> detailList = (from x in db.DetailTransactions where x.TransactionID == transactionId select x).ToList<DetailTransaction>();
            return detailList;
        }

        

    }
}