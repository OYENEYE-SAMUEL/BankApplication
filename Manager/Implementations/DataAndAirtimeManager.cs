using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class DataAndAirtimeManager : IDataAndAirtimeManager
    {
        public DataAndAirtime Create(string rechargeSelf, string rechargeThirdParty, string dailyData, string weeklyData, string monthlyData)
        {
            throw new NotImplementedException();
        }

        public List<DataAndAirtime> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}