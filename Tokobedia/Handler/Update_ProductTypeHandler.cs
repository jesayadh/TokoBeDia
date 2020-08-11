using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Update_ProductTypeHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static List<ProductType> getProductTypeByID(int ID)
        {
            return ProductTypeRepository.getProductTypeByID(ID);
        }

        public static ProductType getProductTypeByName(string typeName)
        {
            return ProductTypeRepository.getProductTypeByName(typeName);
        }

        public static void updateProductType(int updateID, string typeName, string description)
        {
            ProductTypeRepository.updateProductType(updateID, typeName, description);
        }
    }
}