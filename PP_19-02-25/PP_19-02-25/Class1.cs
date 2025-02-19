using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class BankingSystem
    {
        private Dictionary<int, double> accounts = new Dictionary<int, double>();

        private SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>();

        private Queue<int> withdrawalQueue = new Queue<int>();

        public void CreateAccount(int accountId, double initialBalance)
        {
            accounts[accountId] = initialBalance;

            if (!sortedAccounts.ContainsKey(initialBalance))
            {
                sortedAccounts[initialBalance] = new List<int>();
            }
            sortedAccounts[initialBalance].Add(accountId);
        }

        public void Deposit(int accountId, double amount)
        {
            if (accounts.ContainsKey(accountId))
            {
                double currentBalance = accounts[accountId];
                accounts[accountId] = currentBalance + amount;

                sortedAccounts[currentBalance].Remove(accountId);
                if (sortedAccounts[currentBalance].Count == 0)
                {
                    sortedAccounts.Remove(currentBalance);
                }

                if (!sortedAccounts.ContainsKey(currentBalance + amount))
                {
                    sortedAccounts[currentBalance + amount] = new List<int>();
                }
                sortedAccounts[currentBalance + amount].Add(accountId);

                Console.WriteLine($"Deposited {amount} into account {accountId}. New Balance: {accounts[accountId]}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Method to request a withdrawal
        public void RequestWithdrawal(int accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                withdrawalQueue.Enqueue(accountId);
                Console.WriteLine($"Withdrawal request added for account {accountId}.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Method to process the next withdrawal request
        public void ProcessWithdrawal()
        {
            if (withdrawalQueue.Count > 0)
            {
                int accountId = withdrawalQueue.Dequeue();
                double currentBalance = accounts[accountId];
                if (currentBalance > 0)
                {
                    accounts[accountId] = 0;
                    Console.WriteLine($"Processed withdrawal for account {accountId}. Balance is now 0.");
                }
                else
                {
                    Console.WriteLine($"Account {accountId} has no balance to withdraw.");
                }
            }
            else
            {
                Console.WriteLine("No pending withdrawal requests.");
            }
        }

        // Method to display all accounts
        public void DisplaySortedAccounts()
        {
            Console.WriteLine("\nAccounts sorted by balance:");
            foreach (var balance in sortedAccounts)
            {
                Console.WriteLine($"Balance: {balance.Key}, Accounts: {string.Join(", ", balance.Value)}");
            }
        }

        // Method to display the current balance
        public void DisplayBalance(int accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                Console.WriteLine($"Account {accountId} balance: {accounts[accountId]}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }

    class Class1
    {
        public static void Main4()
        {
            BankingSystem bankingSystem = new BankingSystem();

            // Create some accounts
            bankingSystem.CreateAccount(101, 500.0);
            bankingSystem.CreateAccount(102, 200.0);
            bankingSystem.CreateAccount(103, 1500.0);

            // Display initial balances
            bankingSystem.DisplayBalance(101);
            bankingSystem.DisplayBalance(102);
            bankingSystem.DisplayBalance(103);

            // Deposit money into an account
            bankingSystem.Deposit(102, 300.0);

            // Request a withdrawal
            bankingSystem.RequestWithdrawal(101);

            // Process a withdrawal
            bankingSystem.ProcessWithdrawal();

            // Display sorted accounts
            bankingSystem.DisplaySortedAccounts();
        }
    }
}
