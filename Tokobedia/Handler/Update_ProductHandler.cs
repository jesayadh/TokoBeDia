using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Update_ProductHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static dynamic getProductByID(int ID)
        { 
            List<Product> product = ProductRepository.getProductByID(ID);
            var temp = product.Select(p => new
                                    {
                                        p.ProductID,
                                        p.Name,
                                        p.Stock,
                                        p.ProductType.TypeName,
                                        p.Price
                                    });
            return temp;
        }

        public static void updateProduct(int updateID, string name, int stock, int price)
        {
            ProductRepository.updateProduct(updateID, name, stock, price);
        }
    }
}