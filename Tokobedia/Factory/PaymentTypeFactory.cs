using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class PaymentTypeFactory
    {
        public static PaymentType createPaymentType(int typeID, string typeName)
        {
            PaymentType tipeBaru = new PaymentType();
            tipeBaru.PaymentTypeID = typeID;
            tipeBaru.PaymentTypeName = typeName;

            return tipeBaru;
        }
    }
}
