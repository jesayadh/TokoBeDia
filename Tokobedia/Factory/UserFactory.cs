using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Factory
{
    public class UserFactory
    {
        public static User createUser(string email, string name, string password, string gender)
        {
            User users = new User();
            users.Email = email;
            users.Name = name;
            users.Password = password;
            users.Gender = gender;
            users.Status = "active";
            users.RoleID = 2;
            return users;
        }
    }
}