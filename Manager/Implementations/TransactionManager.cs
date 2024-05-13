using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using BankApp.Context;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class TransactionManager : ITransactionManager
    {
        public Transactions Create(int id, string referenceNumber, string transferToBank, string billPayment, string transferToOther, bool isDelivered)
        {
            id = BankAppContext.TransactionsList.Count + 1;
            var refNumber = GenerateReferenceNumber();
            Transactions transactions = new Transactions(id, refNumber, transferToBank, billPayment, transferToOther, isDelivered);
            return transactions;
        }

        private string GenerateReferenceNumber()
        {
            string result = $"ref/dbn/00/81/33";
            return result + 1;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }


        public List<Transactions> GetAllTransactions()
        {
            return BankAppContext.TransactionsList;
        }

        public Transactions GetTransaction(string refNumber)
        {
            foreach (var item in BankAppContext.TransactionsList)
            {
                if (item.ReferenceNumber == refNumber)
                {
                    return item;
                }
            }
            return null;
        }


    }
}