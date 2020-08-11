using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class ProductRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static void insertProduct(string name,int stock, int price, int productTypeID)
        {
            Product produkBaru = Factory.ProductFactory.createProduct(name, stock, price, productTypeID);
            db.Products.Add(produkBaru);
            db.SaveChanges();
        }

        public static List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }

        public static Product getStock(int productID)
        {
            Product currentStock = db.Products.Where(a => a.ProductID == productID).FirstOrDefault();
            return currentStock;
        }

        public static void removeProduct(int productID)
        {
            Product produk = db.Products.Where(a => a.ProductID == productID).FirstOrDefault();
            db.Products.Remove(produk);
            db.SaveChanges();
        }

        public static List<Product> getProductByID(int productID)
        {
            return db.Products.Where(a => a.ProductID == productID).ToList();
        }

        public static Product getSingleProductByID(int productID)
        {
            return db.Products.Where(a => a.ProductID == productID).FirstOrDefault();
        }

        public static void updateProduct(int productID, string name, int stock, int price)
        {
            Product produk = db.Products.Where(a => a.ProductID == productID).FirstOrDefault();
            produk.Name = name;
            produk.Stock = stock;
            produk.Price = price;
            db.SaveChanges();
        }

        public static List<Product> randomList()
        {
            return db.Products.OrderBy(c => Guid.NewGuid()).Take(5).ToList();
        }

        public static Product searchProductTypeInProduct(int typeID)
        {
            return db.Products.Where(x => x.ProductTypeID == typeID).FirstOrDefault();
        }

    }
}