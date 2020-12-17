using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class Bank
    {
        //Fields
        private string bankName;
        private double totalCredit;

        // Property
        public double TotalCredit { get; }

        // Constructor
        public Bank(string name, double total)
        {
            bankName = name;
            totalCredit = total;
        }

        /// <summary>
        /// This is the Bank's header and total credits in the Bank.
        /// </summary>
        /// <returns></returns>
        public string Status()
        {
            string header = $"-------------- Welcome to {bankName}! --------------\n";
            string total = $"The banks total credit:                   {totalCredit:C}\n";
            return header + total;
        }

        /// <summary>
        /// This is where we create new bank accounts.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string name)
        {
            BankAccount newAccount = new BankAccount(name);
            return $"Account created for: {name}!";
        }

        public string Deposit(double depositMoney)
        {
            this.totalCredit += depositMoney;
            return $"Money deposited into Bank: {depositMoney:C}.";
        }

        public string Withdraw(double withdrawMoney)
        {
            this.totalCredit -= withdrawMoney;
            return $"Money withdrawn from Bank: {withdrawMoney:C}.";
        }

        public string Balance()
        {
            return $"Total credit in the bank: {totalCredit:C}.";
        }
    }
}
