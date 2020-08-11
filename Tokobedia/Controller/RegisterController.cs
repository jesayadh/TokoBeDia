using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;

namespace Tokobedia.Controller
{
    public class RegisterController
    { 
        public static string checkEmail(string email)
        {
            if (email == "") 
                return "Must be filled"; 
            else
            {
                if (RegisterHandler.isUserEmailNotUnique(email)) 
                    return "Must be unique"; 
            }
            return "";
        }

        public static string checkName(string name)
        {
            if (name == "")
                return "Must be filled";
            return "";
        }

        public static string checkPassword(string password)
        {
            if (password == "") 
                return "Must be filled";
            return "";
        }

        public static string checkConfirm(string password, string confirm)
        {
            if (confirm == "")
                return "Must be filled";
            else if (confirm != password)
                return "Must be same with password";
            return "";
        }

        public static string checkGender(string gender)
        {
            if (gender == "")
                return "Gender must be chosen";
            return "";
        }

        public static bool registerComplete(string email, string name, string password, string confirm, string gender)
        {
            if (checkEmail(email) != "") return false;
            if (checkName(name) != "") return false;
            if (checkPassword(password) != "") return false;
            if (checkConfirm(password, confirm) != "") return false;
            if (checkGender(gender) != "") return false;

            RegisterHandler.insertUser(email, name, password, gender);
            return true;
        } 
    }
}