using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.View
{
    public class HomeController
    {
        public static User getUserByID(int userId)
        {
            return HomeHandler.getUserByID(userId);
        }
         
        public static int getUserRoleID(object user)
        {
            return HomeHandler.getUserRoleID(user);
        }

        public static string getUserName(object user)
        {
            return HomeHandler.getUserName(user);
        } 

        public static List<Product> listItemGU()
        {
            return HomeHandler.listItemGU();
        }
    }
}