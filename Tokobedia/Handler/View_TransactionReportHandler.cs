using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_TransactionReportHandler
    {
        public static bool isAdmin(object user)
        {
            int roleID = UserRepository.getUserRoleID(user);
            if (roleID == 1) return true;
            return false;
        }

        public static List<HeaderTransaction> getAllHeaderTransaction()
        {
            return HeaderTransactionRepository.getAll();
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionID)
        {
            return DetailTransactionRepository.getDetailTransaction(transactionID);
        }
    }
}