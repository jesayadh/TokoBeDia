using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Insert_ProductHandler
    {
        public static List<ProductType> getProductTypeByID(int ptID)
        {
            return ProductTypeRepository.getProductTypeByID(ptID);
        } 

        public static void toInsertProduct(string name, int stock, int price, int ptID)
        {
            ProductRepository.insertProduct(name, stock, price, ptID);
        }

        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        } 
    }
}