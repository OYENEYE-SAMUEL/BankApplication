using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using BankApp.Manager.Interfaces;

namespace BankApp.Menu
{
    public class AdminBoard
    {
        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to register Director\n Enter 2 to view all Customers\n Enter 3 to view all transactions");
            string option = Console.ReadLine();
            if (option == "1")
            {
                ManagerBoard managerBoard = new ManagerBoard();
                managerBoard.RegisterDirector();
            }
            else if (option == "2")
            {

            }
            else if (option == "3")
            {

            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("==================");
                AdminMenu();
            }
        }
    }
}