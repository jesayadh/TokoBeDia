using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class DetailTransactionFactory
    {
        public static DetailTransaction createDetailTransaction(int transactionID, int productID, int quantity)
        {
            DetailTransaction detailBaru = new DetailTransaction();
            detailBaru.TransactionID = transactionID;
            detailBaru.ProductID = productID;
            detailBaru.Quantity = quantity;

            return detailBaru;
        }
    }
}