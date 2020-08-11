using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Insert_CartHandler
    {
        public static bool checkCart(int productID)
        {
            return CartRepository.checkCart(productID);
        }

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

        public static void insertCart(int userID, int productID, int quantity)
        {
            CartRepository.insertCart(userID, productID, quantity);
        }

        private static Product tempStock;

        public static int getStock(int productID)
        {
            tempStock = Repository.ProductRepository.getStock(productID);
            return tempStock.Stock;
        }

        private static Cart tempQuantity;

        public static int getQuantity(int productID)
        {
            tempQuantity = Repository.CartRepository.getQuantity(productID);
            return tempQuantity.Quantity;
        }
    }
}