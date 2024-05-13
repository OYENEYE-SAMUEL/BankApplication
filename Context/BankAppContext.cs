using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Context
{
    public class BankAppContext
    {
        public static List<User> UserList = new List<User>();
        public static List<Transactions> TransactionsList = new List<Transactions>();
       public static List<Roles> RolesList = new List<Roles>();
       public static List<DataAndAirtime> DataAndAirtimeList = new List<DataAndAirtime>();
       public static List<Customer> CustomerList = new List<Customer>();
       public static List<Director> DirectorList = new List<Director>();
     
    }
}