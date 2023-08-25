using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT21
{

    class BankAccount
    {

        public int AccountNumber;
        public string AccountHolderName;
        public double Balance;


        public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount:C} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }


        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }


        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(12345, "John Doe", 1000.00);

            account.DisplayAccountDetails();

            account.Deposit(500.00);
            account.Withdraw(200.00);

            account.DisplayAccountDetails();
        }
    }
}
