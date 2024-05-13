using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Director : BaseEntity
    {
          public string UserEmail{get; set;} = default!;
        public string StaffNumber{get; set;} = default!;
        public string Qualification{get; set;} = default!;
        public int YearOfExperience{get; set;}

        public Director(int id, string userEmail, string staffNumber,string qualification, int yearOfExperience ) : base(id)
        {
            UserEmail = userEmail;
            StaffNumber = staffNumber;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
        }
    }
}