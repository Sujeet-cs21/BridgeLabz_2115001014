using System;

namespace PP_21_02_25
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Invalid amount!");
            if (amount > Balance)
                throw new InsufficientFundsException("Insufficient balance!");

            Balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + Balance);
        }
    }

    class Class1
    {
        public static void Main10()
        {
            BankAccount account = new BankAccount(500);

            try
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
