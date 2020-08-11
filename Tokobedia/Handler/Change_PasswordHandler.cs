using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Controller
{
    public class Change_PasswordHandler
    { 
        public static string getOldPassword(object user)
        {
            var tempUser = Repository.UserRepository.getCurrent(((Model.User)user).UserID); // cari user dengan id
            return tempUser.Password; // mengambil password dari user dan di return
        }

        public static string toChangePassword(object user, string newBox)
        {
            
             var userID = ((Model.User)user).UserID; // dapetin id dari objek user
             Repository.UserRepository.updatePassword(userID, newBox); // ganti pass, parameternya userID dan pass baru

            return "Ganti Password berhasil!";

        }
    }
}