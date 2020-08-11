using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class View_UserController
    { 
        public static bool getUserRoleID(object user)
        {
            if (View_UserHandler.getUserRoleID(user) != 1)
                return true;

            return false;
        }

        public static dynamic getAllUser()
        {
            return View_UserHandler.getAllUser();
        }

        public static string changeStatus(object user, int choosenID)
        { 
            if (View_UserHandler.getUserID(user) == choosenID) 
                return "Cannot change your own status"; 
            else
                View_UserHandler.changeStatus(choosenID);
            return "Success!";
        }

        public static string changeRole(object user, int choosenID)
        { 
            if (View_UserHandler.getUserID(user) == choosenID)
                return "Cannot change your own role";
            else
                View_UserHandler.changeRole(choosenID);
            return "Success!";
        } 
    }
}