using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BankApp.Context;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class UserManager : IUserManager
    {
        public User CurrentUser()
        {
            return LoginUser;
        }
        public User LoginUser;

        public User Login(string email, string pin)
        {
            foreach (var item in BankAppContext.UserList)
            {
               if (item.Email == email && item.Pin == pin)
               {
                 Console.WriteLine("login successful");
                 LoginUser = item;
                 return item;

               }
            }
            Console.WriteLine("invalid credientials");
            return null;
        }
    }
}