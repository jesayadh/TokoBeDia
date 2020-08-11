using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public class Insert_Payment_TypeController
    {
        public static string toInsertPaymentType(int typeID , string typeName)
        {
            var x = Insert_Payment_TypeHandler.getPaymentTypeByName(typeName);

            if (typeID == null)
            {
                return "ID Must be filled";
            }
            else if (typeName == "" || (typeName != "Cash" && typeName != "Credit"))
            {
                return "Payment Type Must be Filled and must be Cash or Credit";
            }
            else
            {
                var tempPaymentType = Insert_Payment_TypeHandler.getPaymentTypeID(typeID);
                if (tempPaymentType >= 1)
                {
                    return "ID already used";
                }
                else
                {
                    Insert_Payment_TypeHandler.toInsertPaymentType(typeID,typeName);
                    return typeName + " berhasil diinput";
                }
                
            }
        }

        public static bool getUserRoleID(object user)
        {
            if (Insert_Payment_TypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }
    }
}