using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_ProductController
    {
        public static int getUserRoleID(object user)
        {
            return View_ProductHandler.getUserRoleID(user);
        } 

        public static string removeProduct(int productID)
        { 
            return View_ProductHandler.removeProduct(productID);
        }

        public static dynamic listItem()
        {
            return View_ProductHandler.listItem();
        }
    }
}