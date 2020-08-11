using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.Handler
{
    public class View_UserHandler
    {
        public static int getUserRoleID(object user)
        {
            return UserRepository.getUserRoleID(user);
        }

        public static dynamic getAllUser()
        {
            var user = UserRepository.getAllUser();
            var temp = user.Select(u => new
                                {
                                    u.UserID,
                                    u.Role.Name, 
                                    u.Email,
                                    u.Status
                                });
            return temp; 
        }

        public static int getUserID(object user)
        {
            var tempUser =((User)user);
            return tempUser.UserID;
        }

        public static void changeStatus(int choosenID)
        {
            UserRepository.changeStatus(choosenID);
        }

        public static void changeRole(int choosenID)
        {
            UserRepository.changeRole(choosenID);
        } 
    }
}