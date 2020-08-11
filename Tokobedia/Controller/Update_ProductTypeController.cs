using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class Update_ProductTypeController
    {
        public static bool getUserRoleID(object user)
        {
            if (Update_ProductTypeHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }

        public static List<ProductType> getProductTypeByID(int ID)
        {
            return Update_ProductTypeHandler.getProductTypeByID(ID);
        }

        public static string updateProductType(int updateID, string typeName, string description)
        { 
            var tempProductType = Update_ProductTypeHandler.getProductTypeByName(typeName);
            var currentProductType = getProductTypeByID(updateID).FirstOrDefault();
             
            if (description == "")
            {
                return "Description must be filled";
            }
            else if (typeName == "" || typeName.Length < 5 || tempProductType != null)
            {
                if (currentProductType.TypeName == typeName)
                {
                    Update_ProductTypeHandler.updateProductType(updateID, typeName, description);
                }
                else
                    return "Product Type must be filled, unique, and consists of 5 characters or more";
            } 
            else
                Update_ProductTypeHandler.updateProductType(updateID, typeName, description);  
            return "Success!";
        }

        
    }
}