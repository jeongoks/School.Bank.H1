using System;

namespace School.H1_Bank_Project
{
    class Program
    {
        static string menuSelect;
        static Bank ghostBank = new Bank("Ghosten Bank", 150000);

        static void Main(string[] args)
        {
            while (menuSelect != "9")
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
            Console.WriteLine("1. Create Salery Account.\n2. Create Savings Account.\n3. Create Overdraft Account.\n4. Deposit money.\n5. Withdraw money.\n6. Accrue Interest.\n7. Show balance.\n8. Show status.\n9. Exit.");
            menuSelect = Console.ReadLine();

            int amount = 0;
            int accountId = 0;
            string name = "";
            switch (menuSelect)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine("Enter your name here:");
                    name = Console.ReadLine();
                    Console.WriteLine(ghostBank.CreateAccount(name, AccountType.Salery));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine("Enter the clients name:");
                    name = Console.ReadLine();
                    Console.WriteLine(ghostBank.CreateAccount(name, AccountType.Savings));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine("Enter the clients name:");
                    name = Console.ReadLine();
                    Console.WriteLine(ghostBank.CreateAccount(name, AccountType.Overdraft));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    do
                    {
                        Console.WriteLine("Enter your Account ID here:");
                    } while (! int.TryParse(Console.ReadLine(), out accountId));
                    do
                    {
                        Console.WriteLine("Enter the amount of money you want to deposit to you account:");
                    } while (! int.TryParse(Console.ReadLine(), out amount));
                    Console.WriteLine(ghostBank.Deposit(amount, accountId));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    do
                    {
                        Console.WriteLine("Enter your Account ID here:");
                    } while (!int.TryParse(Console.ReadLine(), out accountId));
                    do
                    {
                        Console.WriteLine("Enter the amount of money you want to withdraw from your account:");
                    } while (! int.TryParse(Console.ReadLine(), out amount));
                    try
                    {
                        Console.WriteLine(ghostBank.Withdraw(amount, accountId));
                    }
                    catch (OverdraftException e)
                    {
                        Console.WriteLine($"Negative balance: {e.Message:C}");
                    }
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Accruing interest.");
                    ghostBank.AccrueInterest();
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    do
                    {
                        Console.WriteLine("Enter your Account ID here:");
                    } while (!int.TryParse(Console.ReadLine(), out accountId));
                    Console.WriteLine(ghostBank.Balance(accountId));
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine(ghostBank.PrintHeader());
                    Console.WriteLine(ghostBank.Status());
                    Console.WriteLine("\nPress Enter to return to the menu.\n");
                    Console.ReadLine();
                    break;
                case "9":
                    break;
            }
            return menuSelect;
        }
    }
}
