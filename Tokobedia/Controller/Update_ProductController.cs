using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class Update_ProductController
    {
        public static bool getUserRoleID(object user)
        {
            if (Update_ProductHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }

        public static dynamic getProductByID(int ID)
        {
            return Update_ProductHandler.getProductByID(ID);
        }

        public static string updateProduct(int updateID, string name, int stock, int price)
        {
            if (name == "")
                return "Name must be filled";
            else if (stock < 1)
                return "Stock must be 1 or more";
            else if (price <= 1000 || price % 1000 != 0)
                return "Price must be above 1000 and multiply of 1000";
            else
                Update_ProductHandler.updateProduct(updateID, name, stock, price);
            return "Success!";
        } 
    }
}