using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Manager.Interfaces
{
    public interface IDataAndAirtimeManager
    {
        DataAndAirtime Create(string rechargeSelf, string rechargeThirdParty, string dailyData, string weeklyData, string monthlyData);
        List<DataAndAirtime>GetAll();
    }
}