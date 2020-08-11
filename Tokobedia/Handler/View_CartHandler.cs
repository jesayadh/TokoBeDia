using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_CartHandler
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();

        public static dynamic listItem(int userID)
        {

            var cart = from p in db.Products
                         join c in db.Carts
                         on p.ProductID equals c.ProductID
                         where c.UserID == userID
                         select new
                         {
                             c.CartID,
                             p.Name,
                             p.Price,
                             c.Quantity,
                             SubTotal = p.Price*c.Quantity
                         };
            return cart.ToList();
        }

        public static void removeCart(int cartID)
        {
            CartRepository.removeCart(cartID);
        }
        
        public static List <Cart> getAll(int userID)
        {
            return db.Carts.Where(a => a.UserID == userID).ToList();
        }

        public static void removeAll(List <Cart> myCart)
        {
            foreach(Cart c in myCart)
            {
                CartRepository.removeCart(c.CartID);
            }
        }

        public static void addToTransaction(List <Cart> myCart, int paymentTypeID)
        {
            foreach(Cart c in myCart)
            {
                HeaderTransactionRepository.insertTransaction(c.UserID, paymentTypeID,c.ProductID,c.Quantity);
            }
        }

        public static List<PaymentType> getAllPaymentType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }

    }
}