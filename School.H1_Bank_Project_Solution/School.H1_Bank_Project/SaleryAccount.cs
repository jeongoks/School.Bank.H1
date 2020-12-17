using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class SaleryAccount : BankAccount
    {
        // Constructor
        public SaleryAccount(string name, int accountId)
        {
            AccountName = name;
            AccountId = accountId;
        }

        public override void AccrueInterest()
        {
            Balance += Balance * .5 / 100;
        }
    }
}
