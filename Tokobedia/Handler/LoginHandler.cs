using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Handler
{
    public class LoginHandler
    {
        public static User toLogin(string email, string password)
        {
            return Repository.UserRepository.toLogin(email, password);
        }

        public static string getEmail(int ID)
        {
            return Repository.UserRepository.getCurrent(ID).Email;
        }

        public static string getPassword(int ID)
        {
            return Repository.UserRepository.getCurrent(ID).Password;
        }
    }
}