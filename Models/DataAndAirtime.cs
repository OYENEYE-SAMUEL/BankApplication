using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class DataAndAirtime :BaseEntity
    {
        public string RechargeSelf {get; set;}
        public string RechargeThirdParty {get; set;}
        public string DailyData{get; set;}
        public string WeeklyData{get; set;}
        public string MonthlyData{get; set;}
        
        public DataAndAirtime(int id, string rechargeSelf, string rechargeThirdParty, string dailyData, string weeklyData, string monthlyData) : base(id)
        {
            RechargeSelf = rechargeSelf;
            RechargeThirdParty = rechargeThirdParty;
            DailyData = dailyData;
            WeeklyData = weeklyData;
            MonthlyData = monthlyData;
        }
    }
}