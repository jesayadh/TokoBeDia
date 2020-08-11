using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int userID, int productID, int quantity)
        {
            Cart cartBaru = new Cart();
            cartBaru.UserID = userID;
            cartBaru.ProductID = productID;
            cartBaru.Quantity = quantity;

            return cartBaru;
        }
    }
}