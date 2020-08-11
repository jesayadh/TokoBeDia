using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class CartRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static void insertCart(int userID, int productID, int quantity)
        {
            Cart newCart = Factory.CartFactory.createCart(userID, productID, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();
        }
        
        public static List<Cart> getCartByID(int cartID)
        {
            return db.Carts.Where(a => a.CartID == cartID).ToList();
        }

        public static Cart getProductIDByCartID(int updateID)
        {
            Cart currentProduct = db.Carts.Where(a => a.CartID == updateID).FirstOrDefault();
            return currentProduct;
        }

        public static List<Cart> getAllCart()
        {
            return db.Carts.ToList();
        }

        public static void removeCart(int cartID)
        {
            Cart produk = db.Carts.Where(a => a.CartID == cartID).FirstOrDefault();
            db.Carts.Remove(produk);
            db.SaveChanges();
        }

        public static void updateCart(int productID, int quantity)
        {
            Cart produk = db.Carts.Where(a => a.ProductID == productID).FirstOrDefault();
            produk.Quantity = quantity;
            db.SaveChanges();
        }

        public static bool checkCart(int productID)
        {
            if (db.Carts.Where(y => y.ProductID == productID).FirstOrDefault() != null) // cek product apakah sudah ada
                return true;
            return false;
        }

        public static Cart getQuantity(int productID)
        {
            Cart currentQuantity = db.Carts.Where(a => a.ProductID == productID).FirstOrDefault();
            return currentQuantity;
        }
    }
}