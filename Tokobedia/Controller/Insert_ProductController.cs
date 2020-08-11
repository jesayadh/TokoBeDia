using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;

namespace Tokobedia.View
{
    public class Insert_ProductController
    {
        public static string toInsertProduct(string name, int stock, int price, int ptID)
        { 
            if (name == "")
            { 
                return "Name must be filled";
            }
            else if (stock < 1)
            { 
                return "Stock must be 1 or more";
            }
            else if (!(price > 1000 && price % 1000 == 0))
            { 
                return "Price must be above 1000 and multiply of 1000";
            }
            else
            {
                var tempProductType = Insert_ProductHandler.getProductTypeByID(ptID);
                if (tempProductType == null)
                { 
                    return "Could not Find this ProductTypeID in Database";
                }
                else
                {
                    Insert_ProductHandler.toInsertProduct(name, stock, price, ptID);
                    return "Produk " + name + " sudah berhasil diinput"; 
                } 
            }
        }
         
        public static bool getUserRoleID(object user)
        {
            if (Insert_ProductHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }
    }
}