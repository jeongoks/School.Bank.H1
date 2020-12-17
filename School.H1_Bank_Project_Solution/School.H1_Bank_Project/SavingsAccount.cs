using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class SavingsAccount : BankAccount
    {
        // Constructor
        public SavingsAccount(string name, int accountId)
        {
            AccountName = name;
            AccountId = accountId;
        }

        public override void AccrueInterest()
        {
            if (Balance < 50000)
            {
                Balance += Balance * 1 / 100;
            }
            else if (Balance <= 100000)
            {
                Balance += (50000 * 1 / 100) + ((Balance - 50000) * 2 / 100);
            }
            else if (Balance > 100000)
            {
                /* Making sure that the first 50.000 gets 1% interest, 
                 * then the next 50.000 gets a 2% interest and everything above gets 3% interest. */
                Balance += (50000 * 1 / 100) + (50000 * 2 / 100) + ((Balance - 100000) * 3 / 100);
            }
        }
    }
}
