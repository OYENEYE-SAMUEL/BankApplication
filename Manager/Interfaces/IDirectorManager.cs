using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Manager.Interfaces
{
    public interface IDirectorManager
    {
        Director Register(string email, string pin, string lastName, string firstName, string staffNumber, string address, string phone, Gender gender, MaritalStatus maritalStatus, string qualification, int yearOfExperience);
        Director Get(string staffNumber);
        List<Director>GetAll();
        Director Update(string staffNumber, string qualification);

    }
}