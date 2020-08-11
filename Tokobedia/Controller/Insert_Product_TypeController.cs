using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public class Insert_Product_TypeController
    {
        public static string toInsertProductType(string typeName, string description)
        {
            var x = Insert_Product_TypeHandler.getProductTypeByName(typeName);

            if (typeName == "" || x != null || typeName.Length < 5)
            {
                return "Must be filled, unique, and consists of 5 characters or more";
            } else if (description == "")
            {
                return "Description Must be Filled";
            }
            else
            {
                Insert_Product_TypeHandler.toInsertProductType(typeName, description);
                return typeName + " berhasil diinput"; 
            }
        }

        public static bool getUserRoleID(object user)
        {
            if (Insert_Product_TypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }
    }
}