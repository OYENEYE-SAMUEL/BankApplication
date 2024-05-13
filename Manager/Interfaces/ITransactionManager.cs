using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using BankApp.Models;

namespace BankApp.Manager.Interfaces
{
    public interface ITransactionManager
    {
        Transactions Create(int id, string referenceNumber, string transferToBank, string billPayment, string transferToOther, bool isDelivered);
        Transactions GetTransaction(string referenceNumber);
        List<Transactions>GetAllTransactions();
        bool Delete();
        
    }
}