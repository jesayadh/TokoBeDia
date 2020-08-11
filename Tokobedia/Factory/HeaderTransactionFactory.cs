using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class HeaderTransactionFactory
    {
        public static HeaderTransaction createHeaderTransaction(int userID, int paymentTypeID)
        {
            HeaderTransaction headerBaru = new HeaderTransaction();
            headerBaru.PaymentTypeID = paymentTypeID;
            headerBaru.UserID = userID;
            headerBaru.TransactionDate = DateTime.Now;

            return headerBaru;
        }
    }
}