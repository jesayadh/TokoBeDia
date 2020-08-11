using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;

namespace Tokobedia.Controller
{
    public class Insert_CartController
    {
        public static bool getUserRoleID(object user)
        {
            if (Insert_CartHandler.getUserRoleID(user) != 2)
                return true;

            return false;
        }

        public static dynamic getProductByID(int ID)
        {
            return Insert_CartHandler.getProductByID(ID);
        }

        public static int getStock(int productID)
        {
            return Insert_CartHandler.getStock(productID);
        }

        public static int getQuantity(int productID)
        {
            return Insert_CartHandler.getQuantity(productID);
        }
    }
}