using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Roles : BaseEntity
    {
        public string Name{get; set;} = default!;
        public string Description{get; set;}

        public Roles(int id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }
    }
}