using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class OverdraftAccount : BankAccount
    {
        // Constructor
        public OverdraftAccount(string name, int accountId)
        {
            AccountName = name;
            AccountId = accountId;
        }

        /// <summary>
        /// Accruing interest depending if it's a negative amount or positive amount.
        /// </summary>
        public override void AccrueInterest()
        {
            if (Balance < 0)
            {
                Balance += Balance * 5 / 100;
            }
            else if (Balance > 0)
            {
                Balance += Balance * .5 / 100;
            }
        }
    }
}
