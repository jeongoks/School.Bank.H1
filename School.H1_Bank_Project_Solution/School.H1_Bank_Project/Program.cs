using System;

namespace School.H1_Bank_Project
{
    class Program
    {
        static string menuSelect;
        static Bank ghostBank = new Bank("Ghosten Bank", 150000);

        static void Main(string[] args)
        {
            while (menuSelect != "6")
            {
                Console.Clear();
                Menu();
            }
        }

        /// <summary>
        /// This is our entire Menu, where we call our methods and shows the user what they've added to their account.
        /// </summary>
        /// <returns></returns>
        public static string Menu()
        {
            Console.WriteLine(ghostBank.PrintHeader());
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Create Account.\n2. Deposit money.\n3. Withdraw money.\n4. Show balance.\n5. Show status.\n6. Exit.");
            menuSelect = Console.ReadLine();

            int amount = 0;
            switch (menuSelect)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine("Enter your name here:");
                    Console.WriteLine(ghostBank.CreateAccount(Console.ReadLine()));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    do
                    {
                        Console.WriteLine("Enter the amount of money you want to deposit to you account:");
                    } while (! int.TryParse(Console.ReadLine(), out amount));
                    Console.WriteLine(ghostBank.Deposit(amount));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    do
                    {
                        Console.WriteLine("Enter the amount of money you want to withdraw from your account:");
                    } while (! int.TryParse(Console.ReadLine(), out amount));
                    Console.WriteLine(ghostBank.Withdraw(amount));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine(ghostBank.Balance());
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine(ghostBank.Status());
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "6":
                    break;
            }
            return menuSelect;
        }
    }
}
