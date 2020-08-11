using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tokobedia.Model;

namespace Tokobedia.Repository
{
    public class UserRepository
    {
        static TokobediaDBEntities db = new TokobediaDBEntities();
        public static void insertUser(string email, string name, string password, string gender)
        {
            User users = Factory.UserFactory.createUser(email, name, password, gender);
            db.Users.Add(users);
            db.SaveChanges();
        }

        public static List<User> getAllUser()
        {
            return db.Users.ToList();
        }

        public static User toLogin(string email, string password)
        {
            return (from user in db.Users
                     where user.Email == email
                     && user.Password == password
                     select user).FirstOrDefault();
        }

        public static void updateUser(int userID,string email, string name, string gender)
        {
            User u = db.Users.Where(a => a.UserID == userID).FirstOrDefault();
            u.Email = email;
            u.Name = name;
            u.Gender = gender;
            db.SaveChanges();
        } 

        public static User getCurrent(int userID)
        {
            User currentUser = db.Users.Where(a => a.UserID == userID).FirstOrDefault();
            return currentUser;
        }

        public static bool isUserEmailNotUnique(string email)
        { 
            if (db.Users.Where(y => y.Email == email).FirstOrDefault() != null) // kalau email sudah dipakai
                return true;
            return false;
        }

        public static int getUserRoleID(object user)
        { 
            var tempUser = getCurrent(((Model.User)user).UserID);
            return tempUser.RoleID; 
        }

        public static int getUserRoleID(int userID)
        {
            var tempUser = getCurrent(userID);
            return tempUser.RoleID;
        }

        public static void updatePassword(int userID, string password)
        {
            User u = db.Users.Where(a => a.UserID == userID).FirstOrDefault();
            u.Password = password;
            db.SaveChanges();
        }

        public static void changeStatus(int userID)
        {
            User u = db.Users.Where(a => a.UserID == userID).FirstOrDefault();
            if(u.Status == "active")
            {
                u.Status = "blocked";
            }else if(u.Status == "blocked")
            {
                u.Status = "active";
            }
            db.SaveChanges();
        }

        public static void changeRole(int userID)
        {
            User u = db.Users.Where(a => a.UserID == userID).FirstOrDefault();
            if (u.RoleID == 1)
            {
                u.RoleID = 2;
            }
            else if (u.RoleID == 2)
            {
                u.RoleID = 1;
            }
            db.SaveChanges();
        }

    }
}