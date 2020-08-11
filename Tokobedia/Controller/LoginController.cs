using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Controller;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class LoginController
    {
        public static string checkingInputUser(string email, string password)
        {
            var tempUser = LoginHandler.toLogin(email, password);
            if (tempUser == null) 
                return "Wrong Email or Password"; 
            else if (tempUser.Status == "blocked") 
                return "This user is blocked"; 
            else
                return "Success!";
        }

        public static string getEmail(int ID)
        {
            return LoginHandler.getEmail(ID);
        }
         
        public static string getPassword(int ID)
        {
            return LoginHandler.getPassword(ID);
        }

        public static int getUserId(string email, string password)
        {
            return LoginHandler.toLogin(email, password).UserID;
        }

        public static User toLogin(string email, string password)
        {
            return LoginHandler.toLogin(email, password);
        }
    }
}