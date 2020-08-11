using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;

namespace Tokobedia.Controller
{
    public class Update_CartController
    {
        public static bool getUserRoleID(object user)
        {
            if (Update_ProductHandler.getUserRoleID(user) != 2)
                return true;

            return false;
        }

        public static dynamic getCartByID(int ID)
        {
            return Update_CartHandler.getCartByID(ID);
        }

        public static void addQuantity(int updateID, int quantity)
        {
            Update_CartHandler.updateCart(updateID, quantity);
        }

        public static string updateCart(int updateID, int rquantity, int quantity)
        {
            if (quantity < 1 || quantity > rquantity)
                return "please fill quantity between 1-"+rquantity;
            else
                Update_CartHandler.updateCart(updateID, quantity);
            return "Success!";
        }

        public static int getProductID(int cartID)
        {
            return Update_CartHandler.getProductID(cartID);
        }
    }
}