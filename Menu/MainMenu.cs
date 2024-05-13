using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Manager.Implementations;
using BankApp.Manager.Interfaces;
using BankApp.Models;

namespace BankApp.Menu
{
    public class MainMenu
    {
        UserManager userManager = new UserManager();
        public void Menu()
        {
            Console.WriteLine("Enter 1 to Login\n Enter 2 Logout");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                
                LoginMenu();
            }
            else if (userInput == 2)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("*************\n *******");
                Environment.Exit(0);
                
            }
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your pin");
            string pin = Console.ReadLine();
            var reply = userManager.Login(email, pin);
            if (reply != null)
            {
                if (reply.RoleName == "Admin")
                {
                    AdminBoard adminBoard = new AdminBoard();
                    adminBoard.AdminMenu();
                }
                else if (reply.RoleName == "Director")
                {
                    ManagerBoard  managerBoard = new ManagerBoard();
                    managerBoard.DirectorMenu();
                }
                else if (reply.RoleName == "Customer")
                {
                    CustomerBoard customerBoard = new CustomerBoard();
                    customerBoard.CustomerMenu();
                }
            }
            else
            {
                Menu();
            }
        }

       
    }
}