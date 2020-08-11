using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class Update_ProfileHandler
    {
        public static User getUserByID(int userId)
        {
            return UserRepository.getCurrent(userId);
        }

        public static bool isUserEmailNotUnique(string email)
        {
            return UserRepository.isUserEmailNotUnique(email);
        }

        public static User getUserEmail(object user)
        { 
            return UserRepository.getCurrent(((Model.User)user).UserID);
        }

        public static string updateUser(object user, string email, string name, string gender)
        {
            var currentUser = getUserEmail(user);

            if (isUserEmailNotUnique(email))
            {
                if (currentUser.Email == email)
                {
                    UserRepository.updateUser(currentUser.UserID, email, name, gender);
                }
                else
                    return "Email must be unique";
            }
            else
                UserRepository.updateUser(currentUser.UserID, email, name, gender);
            
           return "Update User Profile berhasil dilakukan";

        }

        internal static string getGender(object user)
        {
            return UserRepository.getCurrent(((Model.User)user).UserID).Gender ;
        }

        internal static string getEmail(object user)
        {
            return UserRepository.getCurrent(((Model.User)user).UserID).Email;
        }

        internal static string getName(object user)
        {
            return UserRepository.getCurrent(((Model.User)user).UserID).Name;
        }
    }
}