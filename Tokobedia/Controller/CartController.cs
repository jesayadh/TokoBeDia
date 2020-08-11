using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class CartController
    {
        public static string checkQuantity(int rquantity,int quantity)
        {
            if (quantity == 0)
                return "Must be filled";
            else
            {
                if (quantity<1||quantity>rquantity)
                    return "Please insert between 1-"+rquantity;     
            }
            return "";
        }

        public static bool insertCartSuccess(int userID, int productID, int rquantity, int quantity)
        {
            if (checkQuantity(rquantity,quantity)!="") return false;
            
            Insert_CartHandler.insertCart(userID,productID,quantity);
            return true;
        }

        public static dynamic listItem(int userID)
        {
            return View_CartHandler.listItem(userID);
        }

        public static string removeCart(int cartID)
        {
                View_CartHandler.removeCart(cartID);
                return "berhasil dihapus";
        }

        public static bool checkCart(int productID)
        {
            if (Insert_CartHandler.checkCart(productID) == true) return true;

            return false;
        }

        public static void checkoutClicked(int userID, int paymentTypeID)
        {
            List<Cart> myCart = View_CartHandler.getAll(userID);
            View_CartHandler.removeAll(myCart);
            View_CartHandler.addToTransaction(myCart, paymentTypeID);
        }
        
        public static List<PaymentType> getAllPaymentType()
        {
            return View_CartHandler.getAllPaymentType();
        }

        public static List<String> convert(List<PaymentType> payment)
        {
            List<String> value = new List<String>();

            foreach(PaymentType pt in payment)
            {
                value.Add(pt.PaymentTypeID.ToString());
            }

            return value;
        }

    }
}