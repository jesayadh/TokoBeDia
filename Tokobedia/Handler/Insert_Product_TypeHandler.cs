using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Controller
{
    public class Insert_Product_TypeHandler
    {
        public static ProductType getProductTypeByName(string typeName)
        {
            return ProductTypeRepository.getProductTypeByName(typeName);
        }

        public static void toInsertProductType(string typeName, string description)
        {
            ProductTypeRepository.insertType(typeName, description);
        }

        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }
    }
}