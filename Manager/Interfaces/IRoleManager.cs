using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Manager.Interfaces
{
    public interface IRoleManager
    {
        Roles Register(string name, string description);
        Roles Get(int id);
        List<Roles> GetAll();
       
    }
}