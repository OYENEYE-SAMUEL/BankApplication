using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Transactions : BaseEntity
    {
        public string ReferenceNumber{get; set;}
        public string TransferToBank{get; set;}
        public string TransferToOtherBank{get; set;}
        public string BillPayment{get; set;}
        public bool IsDelivered{get; set;} 
        

        public Transactions(int id, string referenceNumber, string transferToBank, string transferToOther, string billPayment, bool isDelivered) : base(id)
        {
            ReferenceNumber = referenceNumber;
            TransferToBank = transferToBank;
            TransferToOtherBank = transferToBank;
            BillPayment = billPayment;
            IsDelivered = isDelivered;
        }
    }
}