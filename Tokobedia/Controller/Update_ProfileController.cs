using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class Update_ProfileController
    {
        public static string toUpdateProfile(object user, string email, string name, string gender)
        { 
            

            if (email == "") 
                return "Email must be filled";   
            else if (name == "") 
                return "Name must be filled"; 
            else if (gender == "") 
                return  "Gender must be chosen";
            //else if (Update_ProfileHandler.isUserEmailNotUnique(email))
            //{
            //    if (currentUser.Email == email)
            //    {
            //        Update_ProfileHandler.updateUser(currentUser.UserID, email, name, gender);
            //    }
            //    else
            //        return "Email must be unique";
            //}
            //else
            //    Update_ProfileHandler.updateUser(currentUser.UserID, email, name, gender);
            return Update_ProfileHandler.updateUser(user, email, name, gender); 
        }

        internal static int getGender(object user)
        {
            if (Update_ProfileHandler.getGender(user) == "Male")
                return 0;
            return 1;
        }

        internal static string getEmail(object user)
        {
            return Update_ProfileHandler.getEmail(user);
        }

        internal static string getName(object user)
        {
            return Update_ProfileHandler.getName(user);
        }
    }
}