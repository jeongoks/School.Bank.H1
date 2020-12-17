using System;

namespace School.H1_Bank_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ghostBank = new Bank("Ghosten Bank", 150000);
            Console.WriteLine(ghostBank.Status());
            ghostBank.CreateAccount("Michael");
            Console.WriteLine(ghostBank.Deposit(1300)); 
            Console.WriteLine(ghostBank.Withdraw(300));
            Console.WriteLine(ghostBank.Balance());
        }
    }
}
