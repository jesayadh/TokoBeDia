using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tokobedia.Controller
{
    public class Change_PasswordController
    {
        public static string toChangePassword(object user, string oldBox, string newBox, string confirmBox)
        {
            if (newBox.Length <= 5)
            {
                return "Password baru arus lebih dari 5 huruf";
            }
            else if (confirmBox != newBox)
            {
                return "Password Tidak Sama";
            }
            else if (oldBox == Change_PasswordHandler.getOldPassword(user))
            {
                return Change_PasswordHandler.toChangePassword(user, newBox);
            } 
            return "Password lama salah";
        }
    }
}