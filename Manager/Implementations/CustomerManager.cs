using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Context;
using BankApp.EnumFolder;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class CustomerManager : ICustomerManager
    {
        public Customer Create(string email, string pin, string lastName, string firstName, string address, string phone, Gender gender, MaritalStatus maritalStatus, string utilityBill, int nin)
        {
            var exists = IsExist(email);
            if (exists == true)
            {
                Console.WriteLine($"Customer will this {email} already exist");
                return null;
            }
        
            var id = BankAppContext.UserList.Count + 1;
            User user = new User (id, email, pin, "Customer", lastName, firstName, address, phone, gender, maritalStatus);
           BankAppContext.UserList.Add (user);
          
          var accountNum = GenerateAccountNumber(id);
          var bvnNumber = GenerateBvn(id);
          Customer customer = new Customer (id, email, utilityBill, nin, bvnNumber, accountNum);
          BankAppContext.CustomerList.Add (customer);
          return customer;
        }

         private string GenerateAccountNumber(int id)
        {
             var ranNum = new Random();
            var a = ranNum.Next(0, 40);
            var b = ranNum.Next(52, 100);
            var c = ranNum.Next(200, 300);
            return $"00{id}/{a}/{b}/{c}";
        }

        private int GenerateBvn(int id)
        {
             var ranNum = new Random();
            var a = ranNum.Next(10, 50);
            var b = ranNum.Next(52, 100);
            var c = ranNum.Next(00, 20);
            return a/b/id/c;
        }


        private bool IsExist(string email)
        {
            foreach (var item in BankAppContext.CustomerList)
            {
                if (item.UserEmail == email)
                {
                    return true;
                }
            }
            return false;
        }

        public Customer Get(int id)
        {
            foreach (var item in BankAppContext.CustomerList)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Customer> GetAll()
        {
           return BankAppContext.CustomerList;
        }

        public Customer GetCustomer(string email)
        {
            foreach (var item in BankAppContext.CustomerList)
            {
                if (item.UserEmail == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Customer Update(string email, string pin, string phone, double accountBalance)
        {
            var customer = GetCustomer(email);
            if (customer == null)
            {
                Console.WriteLine($"{email} does not exist");
            }

           customer.AccountBalance += accountBalance;
           
           
           return customer;
        }

    }
}