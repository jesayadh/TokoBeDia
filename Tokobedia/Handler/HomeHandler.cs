using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class HomeHandler
    { 
        public static User getUserByID(int userId)
        {
            return UserRepository.getCurrent(userId); 
        }

        public static int getUserRoleID(object user)
        { 
            return UserRepository.getUserRoleID(user);
        }

        public static string getUserName(object user)
        {
            var tempUser = UserRepository.getCurrent(((Model.User)user).UserID);
            return tempUser.Name;
        }

        public static List<Product> listItemGU()
        {
            var produk = ProductRepository.randomList();

            //var filter =  produk.Select(p => new
            //                            {
            //                                p.ProductID,
            //                                p.Name,
            //                                p.Stock,
            //                                p.ProductType.TypeName,
            //                                p.Price
            //                            });
            return produk;
        }
    }
}