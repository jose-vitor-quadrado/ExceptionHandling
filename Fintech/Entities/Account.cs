using System;
using Fintech.Entities.Exceptions;

namespace Fintech.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public double Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit.");
            }
            if (Balance <= 0.0)
            {
                throw new AccountException("Can't withdraw without cash.");
            }
            if (Balance < amount)
            {
                throw new AccountException("Not enough balance.");
            }
            return Balance -= amount;
        }
    }
}
