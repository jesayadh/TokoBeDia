using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Controller
{
    public class Insert_Payment_TypeHandler
    {
        public static PaymentType getPaymentTypeByName(string typeName)
        {
            return PaymentTypeRepository.getPaymentTypeByName(typeName);
        }

        public static int getPaymentTypeID(int typeID)
        {
            var x = PaymentTypeRepository.getPaymentTypeID(typeID);
            if (x == null) return 0;
            else return 1;
        }
        public static void toInsertPaymentType(int typeID,string typeName)
        {
            PaymentTypeRepository.insertType(typeID,typeName);
        }

        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }
    }
}