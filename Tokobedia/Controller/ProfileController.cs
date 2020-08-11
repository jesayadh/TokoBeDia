using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Handler;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class ProfileController
    { 
        public static int getID(object user)
        {
            return ProfileHandler.getID(user);
        }
        public static string getEmail(object user)
        {
            return ProfileHandler.getEmail(user);
        }

        public static string getName()
        {
            return ProfileHandler.getName();
        }

        public static string getGender()
        {
            return ProfileHandler.getGender();
        }
    }
}