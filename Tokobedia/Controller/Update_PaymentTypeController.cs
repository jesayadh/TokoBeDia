using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class Update_Payment_TypeController
    {
        public static bool getUserRoleID(object user)
        {
            if (Update_Payment_TypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }

        public static List<PaymentType> getPaymentTypeByID(int ID)
        {
            return Update_Payment_TypeHandler.getPaymentTypeByID(ID);
        }

        public static string updatePaymentType(int updateID, string typeName)
        {
            var tempPaymentType = Update_Payment_TypeHandler.getPaymentTypeByName(typeName);
            var currentPaymentType = getPaymentTypeByID(updateID).FirstOrDefault();

            if (typeName ==null|| (typeName != "Cash" && typeName!="Credit"))
            {
               return "Payment Type must be filled and must be Cash or Credit";
            }
            else
                Update_Payment_TypeHandler.updatePaymentType(updateID, typeName);
            return "Success!";
        }
    }
}