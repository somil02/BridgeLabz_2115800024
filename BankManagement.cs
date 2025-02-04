using System;

class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        SetBalance(initialBalance);
    }
    public double GetBalance()
    {
        return balance;
    }
    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("Invalid balance amount. Balance cannot be negative.");
        }
    }
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: $" + GetBalance());
    }
}
class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
        : base(accountNumber, accountHolder, initialBalance)
    {
        this.interestRate = interestRate;
    }

    public void DisplaySavingsAccountDetails()
    {
        DisplayAccountDetails();
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("12345", "Alice", 1000);
        account1.DisplayAccountDetails();
        SavingsAccount savingsAccount = new SavingsAccount("67890", "Bob", 2000, 5);
        savingsAccount.DisplaySavingsAccountDetails();
    }
}
