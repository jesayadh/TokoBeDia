using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;
namespace Tokobedia.Handler
{
    public class Update_Payment_TypeHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static List<PaymentType> getPaymentTypeByID(int ID)
        {
            return PaymentTypeRepository.getPaymentTypeByID(ID);
        }

        public static PaymentType getPaymentTypeByName(string typeName)
        {
            return PaymentTypeRepository.getPaymentTypeByName(typeName);
        }

        public static void updatePaymentType(int updateID, string typeName)
        {
            PaymentTypeRepository.updatePaymentType(updateID, typeName);
        }
    }
}