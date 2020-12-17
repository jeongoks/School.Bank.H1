using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class BankAccount
    {
        // Property
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public int AccountId { get; }

        // Constructor
        public BankAccount(string name, int id)
        {
            AccountName = name;
            AccountId = id;
            Balance = 0;
        }
    }
}
