using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using BankApp.EnumFolder;

namespace BankApp.Models
{
    public class User : BaseEntity
    {
        public string Email{get; set;} = default!;
        public string Pin{get; set;}
        public string RoleName{get; set;} = default!;
        public string LastName{get; set;} = default!;
        public string FirstName{get; set;} = default!;
        public string? Address{get; set;}
        public string Phone{get; set;}
        public Gender Gender{get; set;}
        public MaritalStatus MaritalStatus{get; set;}

        public User(int id, string email, string pin, string roleName, string lastName, string firstName, string address, string phone, Gender gender, MaritalStatus maritalStatus) : base(id)
        {
            Email = email;
            Pin = pin;
            RoleName = roleName;
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            Phone = phone;
            Gender = gender;
            MaritalStatus = maritalStatus;  
        }
        
    }
}