using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Customer : BaseEntity
    {
        public string UserEmail { get; set; } = default!;
        public string UtilityBill { get; set; } = default!;
        public int Nin { get; set; }
        public int Bvn { get; set; }
        public double AccountBalance { get; set; }
        public string AccountNumber { get; set; }
       

        public Customer(int id, string userEmail, string utilityBill, int nin, int bvn, double accountBalance, string accountNumber) : base(id)
        {
            UserEmail = userEmail;
            UtilityBill = utilityBill;
            Nin = nin;
            Bvn = bvn;
            AccountBalance = accountBalance;
            AccountNumber = accountNumber;
           
        }
    }
}