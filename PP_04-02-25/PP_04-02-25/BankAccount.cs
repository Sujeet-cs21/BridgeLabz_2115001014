using System;

namespace PP_04_02_25
{
    public class BankAccount
    {
        // Static variables
        public static string bankName = "Static Bank";
        private static int totalAccounts = 0;

        // Readonly variable
        public readonly int AccountNumber;

        // Account holder's name
        public string AccountHolderName;

        // Constructor
        public BankAccount(string AccountHolderName, int AccountNumber)
        {
            // Using 'this' to resolve ambiguity
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;

            totalAccounts++;
        }

        // Static method to get total accounts
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            // Using 'is' operator to check instance type
            if (this is BankAccount)
            {
                Console.WriteLine("Bank Name: " + bankName);
                Console.WriteLine("Account Holder: " + AccountHolderName);
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("**************************");
            }
            else
            {
                Console.WriteLine("Invalid account object.");
            }
        }

         public static void RunBankAccountClass()
         {
            // Creating accounts
            BankAccount acc1 = new BankAccount("AccountHolder1", 1001);
            BankAccount acc2 = new BankAccount("AccountHolder2", 1002);

            // Display details
            acc1.DisplayAccountDetails();
            acc2.DisplayAccountDetails();

            // Display total accounts
            BankAccount.GetTotalAccounts();
         }
    }

}
