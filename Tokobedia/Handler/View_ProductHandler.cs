using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_ProductHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static bool adaHubungan(int productID)
        {
            if (DetailTransactionRepository.searchProductInDetailTransaction(productID) != null)
                return true;
            else
                return false;
        }

        public static string removeProduct(int productID)
        {
            if (adaHubungan(productID))
                return "Product tidak boleh memiliki hubungan dengan tabel lain";
            else
            {
                string name = getRemovedProductName(productID);
                ProductRepository.removeProduct(productID);
                return name + " berhasil dihapus";
            }
        }

        public static string getRemovedProductName(int productID)
        {
            var tempProduct = ProductRepository.getProductByID(productID).FirstOrDefault();
            return tempProduct.Name;
        }
        

        public static dynamic listItem()
        {
            List<Product> product = ProductRepository.getAllProduct();
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
    }
}