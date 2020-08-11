using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class ProductTypeFactoy
    {
        
        public static ProductType createProductType(string typeName, string description)
        {
            ProductType tipeBaru = new ProductType();
            tipeBaru.TypeName = typeName;
            tipeBaru.Description = description;

            return tipeBaru;
        }
    }
}