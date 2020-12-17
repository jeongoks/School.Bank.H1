﻿using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class Bank
    {
        //Fields
        private string bankName;
        private double totalCredit;
        private List<BankAccount> accounts;
        private int accountIdCount;

        // Property
        public double TotalCredit { get; }

        // Constructor
        public Bank(string name, double total)
        {
            bankName = name;
            totalCredit = total;
            accounts = new List<BankAccount>();
        }

        /// <summary>
        /// This is the Bank's header.
        /// </summary>
        /// <returns></returns>
        public string PrintHeader()
        {
            string header = $"----------------------------------------------------\n------------- Welcome to {bankName}! -------------\n";
            string underline = $"----------------------------------------------------";
            return header + underline;
        }

        /// <summary>
        /// This is the Banks total credit.
        /// </summary>
        /// <returns></returns>
        public string Status()
        {
            double total = totalCredit;
            StringBuilder builder = new StringBuilder();
            accounts.ForEach(account => {
                total += account.Balance;
                builder.Append($"Account {account.AccountId} balance: {account.Balance:C}\n");
            } );
            builder.Append($"The bank full credit is: {total:C}\n");
            return builder.ToString();
        }

        /// <summary>
        /// This is where we create new bank accounts.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string name, AccountType accountType)
        {
            BankAccount newAccount = null;
            if (accountType == AccountType.Savings)
            {
                newAccount = new SavingsAccount(name, accountIdCount);
            }
            else if (accountType == AccountType.Overdraft)
            {
                newAccount = new OverdraftAccount(name, accountIdCount);
            }
            else if (accountType == AccountType.Salery)
            {
                newAccount = new SaleryAccount(name, accountIdCount);
            }

            if (newAccount != null)
            {
                accounts.Add(newAccount);
                accountIdCount++;
                return $"Account created for: {name} with the id: {newAccount.AccountId}!";
            }
            return $"Wrong type of account!";
        }

        /// <summary>
        /// For every account, Accrue Interest.
        /// </summary>
        public void AccrueInterest()
        {
            accounts.ForEach(account => account.AccrueInterest());
        }

        /// <summary>
        /// This is where we deposit money into our Balance on the specified Account through the Account Id
        /// </summary>
        /// <param name="depositMoney"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public string Deposit(double depositMoney, int accountId)
        {
            BankAccount account = this.accounts.Find(item => item.AccountId == accountId);
            if (account != null)
            {
                account.Balance += depositMoney;
                return $"Money deposited into Bank: {depositMoney:C}.";
            }
            return $"Wrong account id: {accountId}!";            
        }

        /// <summary>
        /// This is where we withdraw money from our Balance on the specified Account.
        /// </summary>
        /// <param name="withdrawMoney"></param>
        /// <param name="accountId">Specific Account Id</param>
        /// <returns></returns>
        public string Withdraw(double withdrawMoney, int accountId)
        {
            BankAccount account = this.accounts.Find(item => item.AccountId == accountId);
            if (account != null)
            {
                account.Balance -= withdrawMoney;
                return $"Money withdrawn from Bank: {withdrawMoney:C}.";
            }
            return $"Wrong account id: {accountId}!";
        }

        /// <summary>
        /// This is where we can see the Balance on a specific account, using the Account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public string Balance(int accountId)
        {
            BankAccount account = this.accounts.Find(item => item.AccountId == accountId);
            if (account != null)
            {
                return $"Money in the account: {account.Balance:C}.";
            }
            return $"Wrong account id: {accountId}!";
        }
    }
}
