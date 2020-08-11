using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class PaymentTypeRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();

        public static void insertType(int typeID, string typeName)
        {
            PaymentType paymentbaru = Factory.PaymentTypeFactory.createPaymentType(typeID, typeName);
            db.PaymentTypes.Add(paymentbaru);
            db.SaveChanges();
        }
        public static List<PaymentType> getAllPaymentType()
        {
            return db.PaymentTypes.ToList();
        }

        public static void removeType(string typeName)
        {
            PaymentType cariTipe = db.PaymentTypes.Where(a => a.PaymentTypeName == typeName).FirstOrDefault();
            db.PaymentTypes.Remove(cariTipe);
            db.SaveChanges();
        }

        public static List<PaymentType> getPaymentTypeByID(int PaymentTypeID)
        {
            return db.PaymentTypes.Where(a => a.PaymentTypeID == PaymentTypeID).ToList();
        }

        public static PaymentType getPaymentTypeID(int PaymentTypeID)
        {
            return db.PaymentTypes.Where(a => a.PaymentTypeID == PaymentTypeID).FirstOrDefault();
        }

        public static PaymentType getPaymentTypeByName(string typeName)
        {
            return db.PaymentTypes.Where(a => a.PaymentTypeName == typeName).FirstOrDefault();
        }

        public static void updatePaymentType(int typeID, string typeName)
        {
            PaymentType tipeProduk = db.PaymentTypes.Where(a => a.PaymentTypeID == typeID).FirstOrDefault();
            tipeProduk.PaymentTypeName = typeName;
            db.SaveChanges();
        }
        
    }
}
