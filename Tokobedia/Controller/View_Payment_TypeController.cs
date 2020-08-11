using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_Payment_TypeController
    {
        public static bool getUserRoleID(object user)
        {
            if (View_Payment_TypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }

        public static string removePayment(String typeName)
        {
            
                View_Payment_TypeHandler.removeType(typeName);
                return typeName + " berhasil dihapus";
        }

        public static List<PaymentType> listType()
        {
            return View_Payment_TypeHandler.listType();
        }
    }
}
