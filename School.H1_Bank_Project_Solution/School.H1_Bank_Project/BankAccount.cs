using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class BankAccount
    {
        // Fields
        private string name;
        private double balance;

        // Property
        public double Balance { get; set; }

        // Constructor
        public BankAccount(string nam)
        {
            name = nam;
            balance = 0;
        }
    }
}
