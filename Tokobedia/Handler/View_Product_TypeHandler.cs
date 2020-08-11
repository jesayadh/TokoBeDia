using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_Product_TypeHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static bool adaHubungan(string typeName)
        {
            int typeID = ProductTypeRepository.getProductTypeByName(typeName).ProductTypeID;
            if (ProductRepository.searchProductTypeInProduct(typeID) != null)
                return true;
            else
                return false;
        }

        public static string removeType(string typeName)
        {
            if (adaHubungan(typeName))
                return "Tipe Produk tidak boleh memilikki hubungan dengan tabel lain";
            else
            { 
                ProductTypeRepository.removeType(typeName);
                return typeName + " berhasil dihapus";
            }
        } 

        public static List<ProductType> listType()
        { 
            return ProductTypeRepository.getAllProductType(); 
        }
    }
}