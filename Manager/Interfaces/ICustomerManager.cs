using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.EnumFolder;
using BankApp.Models;

namespace BankApp.Manager.Interfaces
{
    public interface ICustomerManager
    {
        Customer Create(string email, string pin, string lastName, string firstName, string address, string phone, Gender gender, MaritalStatus maritalStatus, string utilityBill, int nin);
        Customer Get(int id);
        Customer GetCustomer(string email);
        List<Customer> GetAll();
        Customer Update(string email, string pin, string phone, double accountBalance);

    }
}