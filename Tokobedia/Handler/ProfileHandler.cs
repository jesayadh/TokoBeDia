using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Handler
{
    public class ProfileHandler
    {
        private static User tempUser;

        public static string getEmail(object user)
        {  
            tempUser = Repository.UserRepository.getCurrent( ((Model.User)user).UserID );
            return tempUser.Email;
        }

        public static string getName()
        { 
            return tempUser.Name;
        }

        public static string getGender()
        { 
            return tempUser.Gender;
        }

        public static int getID(object user)
        {
            tempUser = Repository.UserRepository.getCurrent(((Model.User)user).UserID);
            return tempUser.UserID;
        }
    }
}