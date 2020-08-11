using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class ProductTypeRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static void insertType(string name, string description)
        {
            ProductType tipeBaru = Factory.ProductTypeFactoy.createProductType(name, description);
            db.ProductTypes.Add(tipeBaru);
            db.SaveChanges();
        }

        public static List<ProductType> getAllProductType()
        {
            return db.ProductTypes.ToList();
        }

        public static void removeType(string typeName)
        {
            ProductType cariTipe = db.ProductTypes.Where(a => a.TypeName == typeName).FirstOrDefault();
            db.ProductTypes.Remove(cariTipe);
            db.SaveChanges();
        }

        public static List<ProductType> getProductTypeByID(int productTypeID)
        {
            return db.ProductTypes.Where(a => a.ProductTypeID == productTypeID).ToList();
        }

        public static ProductType getProductTypeByName(string typeName)
        {
            return db.ProductTypes.Where(a => a.TypeName == typeName).FirstOrDefault();
        }

        public static void updateProductType(int typeID, string typeName, string description)
        {
            ProductType tipeProduk = db.ProductTypes.Where(a => a.ProductTypeID == typeID).FirstOrDefault();
            tipeProduk.TypeName = typeName;
            tipeProduk.Description = description;
            db.SaveChanges();
        }
    }
}