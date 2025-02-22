using System;

namespace PP_22_02_25_NUnit
{
    public class BankAccount
    {
        private double _balance;

        public BankAccount(double initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than zero.");

            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be greater than zero.");

            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds.");

            _balance -= amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
