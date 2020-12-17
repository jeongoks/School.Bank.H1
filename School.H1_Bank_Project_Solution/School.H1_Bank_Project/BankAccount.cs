using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public enum AccountType { Savings, Salery, Overdraft }

    public abstract class BankAccount
    {
        // Property
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public int AccountId { get; protected set; }

        public abstract void AccrueInterest();
    }
}
