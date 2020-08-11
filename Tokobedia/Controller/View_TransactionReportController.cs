using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_TransactionReportController
    {
        public static bool isAdmin(object user)
        {
            if (View_TransactionReportHandler.isAdmin(user))
                return true;
            return false;
        }

        public static DataSet1 getDatasetForReport()
        {
            DataSet1 dataset = new DataSet1();
            var headerTransaction = dataset.HeaderTransaction;
            var detailTransaction = dataset.DetailTransaction;

            List<HeaderTransaction> header = View_TransactionReportHandler.getAllHeaderTransaction();
            foreach (HeaderTransaction h in header)
            {
                var row = headerTransaction.NewRow();
                row["TransactionID"] = h.TransactionID;
                row["Date"] = h.TransactionDate;
                row["UserID"] = h.UserID;
                row["PaymentTypeID"] = h.PaymentTypeID;
                headerTransaction.Rows.Add(row);

                List<DetailTransaction> details = View_TransactionReportHandler.getDetailTransaction(h.TransactionID);
                foreach (DetailTransaction d in details)
                {
                    var rowDetail = detailTransaction.NewRow();
                    rowDetail["TransactionID"] = d.TransactionID;
                    rowDetail["ProductID"] = d.ProductID;
                    rowDetail["Quantity"] = d.Quantity;
                    int price = View_TransactionHistoryHandler.getPrice(d.ProductID);
                    rowDetail["Price"] = price;
                    detailTransaction.Rows.Add(rowDetail);
                }
            }


            return dataset;
        }
    }
}