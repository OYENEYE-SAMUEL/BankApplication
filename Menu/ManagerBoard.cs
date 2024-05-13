using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Manager.Implementations;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Menu
{
    public class ManagerBoard
    {
       
       IDirectorManager directorManager;
        public void DirectorMenu()
        {
             Console.WriteLine("Enter 1 to Register\n Enter 2 to Menu");
            int dirInput = int.Parse(Console.ReadLine());

            if (dirInput == 1)
            {
                RegisterDirector();
            }
            else if (dirInput == 2)
            {
                MainMenu mainMenu = new MainMenu();
               mainMenu.Menu();
            }
            else
            {
                Console.WriteLine("Invalid input");
                DirectorMenu();
            }
        }
        public void RegisterDirector()
        {
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin");
            string pin = Console.ReadLine();
            Console.Write("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.Write("Enter your address");
            string address = Console.ReadLine();
            Console.Write("Enter your Phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter your Gender\n press 1 for male\n press 2 for female");
            int gender = int.Parse(Console.ReadLine());
            if (gender != 1 || gender != 2)
            {
                Console.WriteLine("Enter 1 or 2");
            }
            Console.WriteLine("Enter your Marital status\n press 1 for Single");
            Console.WriteLine("press 2 for Married\n press 3 for Divorce");
            int maritalStatus = int.Parse(Console.ReadLine());
            if (maritalStatus != 1 || maritalStatus != 2 || maritalStatus != 3)
            {
                Console.WriteLine("Oooopss...Enter a valid number");
            }
            Console.WriteLine("Enter your qualification");
            string qualification = Console.ReadLine();
            Console.WriteLine("Enter your year of Experience");
            int year = int.Parse(Console.ReadLine());
            directorManager.Register(email, pin, lastName, firstName, address, phone, gender, maritalStatus, qualification, year);
            

        }
    }
}