using System;
using System.Collections.Generic;

namespace PP_10_02_25
{
    // Abstract class BankAccount
    abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string HolderName { get; private set; }
        protected double Balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient funds.");
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber + ", Holder: " + HolderName + ", Balance: " + Balance + ", Interest: " + CalculateInterest());
        }
    }

    // Interface ILoanable
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // SavingsAccount class
    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.04; // 4% interest
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine("Loan application received for: " + amount);
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 2; // Eligible for twice the balance
        }
    }

    // CurrentAccount class
    class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.02; // 2% interest
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine("Loan application received for: " + amount);
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 3; // Eligible for three times the balance
        }
    }

    class Class4
    {
        public static void Main4()
        {
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount("AB123", "Abc", 5000),
                new CurrentAccount("CD456", "Cde", 10000)
            };

            foreach (var account in accounts)
            {
                account.DisplayDetails();
            }
        }
    }
}
