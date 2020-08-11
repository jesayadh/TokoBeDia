using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Update_CartHandler
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static void updateCart(int updateID, int quantity)
        {
            CartRepository.updateCart(updateID, quantity);
        }

        public static dynamic getCartByID(int ID)
        {
            List<Cart> produk = CartRepository.getCartByID(ID);
            var temp = produk.Select(p => new
            {
                p.CartID,
                p.Product.Name,
                p.Product.Price,
                p.Quantity
            });
            return temp;
        }

        private static Cart idProduct;

        public static int getProductID(int CartID)
        {
            idProduct = Repository.CartRepository.getProductIDByCartID(CartID);
            return idProduct.ProductID;
        }
    }
}