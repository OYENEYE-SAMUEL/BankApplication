using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Context;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class RolesManager : IRoleManager
    {
        public Roles Register(string name, string description)
        {
           var exists = isExist(name);
           if (exists)
           {
            Console.WriteLine($"The role {name} does not exist");
           }

           var id = BankAppContext.RolesList.Count + 1;
           Roles role = new Roles(id, name, description);
           BankAppContext.RolesList.Add(role);
           Console.WriteLine("Registration successfully");
           return role;
        }

         private bool isExist(string name)
        {
            foreach (var duty in BankAppContext.RolesList)
            {
              if (duty.Name == name) 
              {
                return true;
              }
            }
            return false;
        }

        public Roles Get(int id)
        {
           foreach (var item in BankAppContext.RolesList)
           {
             if(item.Id == id)
             {
                return item;
             }
           }
             return null;
        }

        public List<Roles> GetAll()
        {
          return  BankAppContext.RolesList;
        }

        
        // public Roles Update(string name, string description)
        // {
        //     var role = Get(name);
        //         if (role == null)
        //         {
        //             Console.WriteLine($"{name} does not exist");  
        //         }

        //     return null;
               
        // }

        // private object Get(string name)
        // {
        //     throw new NotImplementedException();
        // }
    }


}