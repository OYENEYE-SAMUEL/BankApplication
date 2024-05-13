using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BankApp.Manager.Implementations;
using BankApp.Manager.Interfaces;

namespace BankApp.Menu
{
    public class CustomerBoard
    {
        ICustomerManager customerManager = new CustomerManager();
        public void CustomerMenu()
        {
            Console.WriteLine("Enter 1 to Register\n Enter 2 to Menu");
            int cusInput = int.Parse(Console.ReadLine());

            if (cusInput == 1)
            {
                RegisterCustomer();

            }
            else if (cusInput == 2)
            {
               MainMenu mainMenu = new MainMenu();
               mainMenu.Menu();
            }
            else
            {
                Console.WriteLine("Invalid input");
                CustomerMenu();
            }
        }
        public void RegisterCustomer()
        {
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin");
            string pin = Console.ReadLine();
            Console.Write("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine("Upload your Utility bill like Electricity bill, Water bill etc");
            string utilityBill = Console.ReadLine();
            Console.WriteLine("Enter you NIN slip number");
            int nin = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Which type of account do you wish to open");
            Console.WriteLine("Press 1 for Savings Account");
            Console.WriteLine("Press 2 for Current Account");
            Console.WriteLine("Press 3 for Domiciliary Account");
            Console.WriteLine("Press 4 for Business Account");
            Console.WriteLine("Press 5 for Student Acccount");
            int accountType = int.Parse(Console.ReadLine());
            if (accountType != 1 || accountType != 2 || accountType != 3 || accountType != 4 || accountType != 5)
            {
                Console.WriteLine("Enter a valid number from the options");
            }
            customerManager.Create(email, pin, lastName, firstName, address, phone, gender, maritalStatus, utilityBill);
        }
    }
}