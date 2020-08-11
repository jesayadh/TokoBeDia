using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class ProductFactory
    {
        public static Product createProduct(string name, int stock, int price, int productTypeID)
        {
            Product produkBaru = new Product();
            produkBaru.Name = name;
            produkBaru.Stock = stock;
            produkBaru.Price = price;
            produkBaru.ProductTypeID = productTypeID;

            return produkBaru; 
        }
    }
}