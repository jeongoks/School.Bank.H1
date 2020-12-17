using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public abstract class BankAccount
    {
        // Property
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public int AccountId { get; protected set; }

        public abstract void AccrueInterest();
    }
}
