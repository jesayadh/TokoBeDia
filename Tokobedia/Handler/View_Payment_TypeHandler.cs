using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_Payment_TypeHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static void removeType(string typeName)
        {
            PaymentTypeRepository.removeType(typeName);
        }

        public static List<PaymentType> listType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }

    }
}
