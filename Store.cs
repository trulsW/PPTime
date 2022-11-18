using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTime
{
    public class Store
    {

        public void Run()
        {
            ShowMenu();
            HandleMenuOptions();
        }

        public List<Produckt> ListOfProducts { get; set; }
        public CashRegister cashRegister = new CashRegister();

        public Store()
        {
            ListOfProducts = new List<Produckt>()
            {
                new Produckt("PC", 1456),
                new Produckt("Monitor", 678),
            };

           
        }

        public void ShowMenu()
        {
            Console.WriteLine("welcome to ProShop");
            Console.WriteLine("1.Show list of products");
            Console.WriteLine("2.Show total balance");
            Console.WriteLine("3.Show todays profit");
        }

        public void HandleMenuOptions()
        {
            var menuOptions = Convert.ToInt32(Console.ReadLine());

            if(menuOptions == 1)
            {
                ShowListOfProducts();
                BackToMenuOrExit();
            }
            else if(menuOptions == 2)
            {
                cashRegister.ShowTotalBalance();
                BackToMenuOrExit();
            }
            else if( menuOptions == 3)
            {
                
                cashRegister.ShowTodaysProfit();
                BackToMenuOrExit();
            }
        }

        public void ShowListOfProducts()
        {
            foreach (var product in ListOfProducts)
            {
                product.ShowProdukts();
                
            }
    
        }

        public void BackToMenuOrExit()
        {
            Console.Write("To go back to menu, please press M. To exit the program, please press X: ");
            var inputChoice = Console.ReadLine();
            
                if (inputChoice == "M" || inputChoice == "m")
                {
                    ShowMenu();
                }
                else if (inputChoice == "X" || inputChoice == "x")
                {
                Console.WriteLine("Husk å fikse exit program funksjon");
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    BackToMenuOrExit();
                 }
            
            
        }

       
    }
}
