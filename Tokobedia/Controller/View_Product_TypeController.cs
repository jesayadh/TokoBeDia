using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_Product_TypeController
    {
        public static bool getUserRoleID(object user)
        {
            if (View_Product_TypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }
          
        public static string removeProduct(String typeName)
        { 
            return View_Product_TypeHandler.removeType(typeName);
        }

        public static List<ProductType> listType()
        {
            return View_Product_TypeHandler.listType();
        }
    }
}