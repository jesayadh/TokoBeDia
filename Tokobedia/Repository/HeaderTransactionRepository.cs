using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Factory;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class HeaderTransactionRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static List<HeaderTransaction> getAll()
        {
            return db.HeaderTransactions.ToList();
        }

        public static void insertTransaction(int userID, int paymentTypeID, int productID, int quantity)
        {
            HeaderTransaction headerBaru = HeaderTransactionFactory.createHeaderTransaction(userID, paymentTypeID);
            db.HeaderTransactions.Add(headerBaru);
            db.SaveChanges();
            DetailTransaction detailBaru = DetailTransactionFactory.createDetailTransaction(headerBaru.TransactionID, productID, quantity);
            db.DetailTransactions.Add(detailBaru);
            db.SaveChanges();
        }

    }

}