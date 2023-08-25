using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public int AccountNumber { get; }
    public string AccountHolderName { get; }
    public decimal Balance { get; private set; }

    public BankAccount(int accountNumber, string accountHolderName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"{amount:C} deposited successfully. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"{amount:C} withdrawn successfully. New balance: {Balance:C}");
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(12345, "Shivam Saini", 1000.00m);

        account.DisplayAccountDetails();
        Console.WriteLine();

        account.Deposit(500.00m);
        account.Withdraw(200.00m);
        account.Withdraw(1500.00m);

        account.DisplayAccountDetails();
    }
}
