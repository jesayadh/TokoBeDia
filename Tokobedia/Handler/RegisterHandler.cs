using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class RegisterHandler
    {
        public static bool isUserEmailNotUnique(string email)
        {
            return UserRepository.isUserEmailNotUnique(email); 
        }

        public static void insertUser(string email, string name, string password, string gender)
        {
            UserRepository.insertUser(email, name, password, gender);
        }
        
    }
}