using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BankApp.Context;
using BankApp.EnumFolder;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Manager.Implementations
{
    public class ManagerManager : IDirectorManager
    {
        public Director Register(string email, string pin, string lastName, string firstName, string staffNumber, string address, string phone, Gender gender, MaritalStatus maritalStatus, string qualification, int yearOfExperience)
        {
            var exist = isExist(email);
            if (exist == true)
            {
                Console.WriteLine($"The staff {email} already exist");
                return null;
            }

            var id = BankAppContext.UserList.Count + 1;
            User user = new User(id, email, pin, "Director", lastName, firstName, address, phone, gender, maritalStatus);
            BankAppContext.UserList.Add(user);

            var staffNum = GenerateStaffNumber(id, lastName, firstName);
            Director director = new Director(id, email, staffNum, qualification, yearOfExperience);
            BankAppContext.DirectorList.Add(director);
            return director;

        }
        public string GenerateStaffNumber(int id, string lastName, string firstName)
        {
            return $"DIB/NG/365{id}/{lastName}/{firstName}";
        }

        private bool isExist(string email)
        {
            foreach (var item in BankAppContext.DirectorList)
            {
                if (item.UserEmail == email)
                {
                    return true;
                }
            }
            return false;
        }


        public Director Get(string staffNum)
        {
            foreach (var item in BankAppContext.DirectorList)
            {
                if (item.StaffNumber == staffNum)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Director> GetAll()
        {
            return BankAppContext.DirectorList;
        }



        public Director Update(string staffNumber, string qualification)
        {
            var director = Get(staffNumber);
            if (director == null)
            {
                Console.WriteLine($"{staffNumber} was not found.");
            }
            director.Qualification = qualification;
            return director;
        }

       
    }
}