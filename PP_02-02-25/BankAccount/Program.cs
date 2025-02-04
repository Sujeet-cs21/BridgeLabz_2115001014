using System;

class BankAccount
{
    // Public variable
    public string accountNumber;

    // Protected variable
    protected string accountHolder;

    // Private variable
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber, string accountHolder, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to access the balance
    public decimal GetBalance()
    {
        return balance;
    }

    // Public method to modify the balance
    public void SetBalance(decimal newBalance)
    {
        if (newBalance >= 0)
        {
            balance = newBalance;
            Console.WriteLine("Balance updated: " + balance);
        }
        else
        {
            Console.WriteLine("Balance cannot be negative!");
        }
    }
}

class SavingsAccount : BankAccount
{
    // Constructor to initialize the SavingsAccount class
    public SavingsAccount(string accountNumber, string accountHolder, decimal balance)
        : base(accountNumber, accountHolder, balance) { }

    // Method to display SavingsAccount details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);   // Accessible (public)
        Console.WriteLine("Account Holder: " + accountHolder); // Accessible (protected)
        Console.WriteLine("Balance: " + GetBalance());   // Accessible via public GetBalance method
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of BankAccount
        BankAccount account1 = new BankAccount("12345678", "Person1", 1000.50m);

        // Access and modify the balance using public methods
        Console.WriteLine("Original Balance: " + account1.GetBalance());
        account1.SetBalance(1500.75m);

        // Create an instance of SavingsAccount 
        SavingsAccount savingsAccount = new SavingsAccount("98765432", "Person2", 2000.00m);
        savingsAccount.DisplayAccountDetails();  // Display SavingsAccount details
    }
}
