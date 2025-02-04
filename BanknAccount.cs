//public class BankAccount
//{
//    // Static variable shared across all instances
//    public static string bankName = "SBI";

//    // Static counter to track the total number of accounts
//    private static int TotalAccounts = 0;

//    // Account holder's name
//    public string AccountHolderName { get; private set; }

//    // Readonly variable for AccountNumber
//    private readonly int AccountNumber;

//    // Static method to get the total number of accounts
//    public static int GetTotalAccounts()
//    {
//        return TotalAccounts;
//    }

//    // Constructor to initialize fields using 'this' keyword
//    public BankAccount(string accountHolderName, int accountNumber)
//    {
//        this.AccountHolderName = accountHolderName;
//        this.AccountNumber = accountNumber;
//        TotalAccounts++;
//    }

//    // Display account details using the 'is' operator
//    public void DisplayAccountDetails()
//    {
//        if (this is BankAccount)
//        {
//            Console.WriteLine("Bank Name: " + bankName);
//            Console.WriteLine("Account Holder: " + AccountHolderName);
//            Console.WriteLine("Account Number: " + AccountNumber);
//        }
//        else
//        {
//            Console.WriteLine("This is not a valid BankAccount object.");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        BankAccount account1 = new BankAccount("John Doe", 12345);
//        BankAccount account2 = new BankAccount("Jane Doe", 54321);

//        account1.DisplayAccountDetails();
//        Console.WriteLine(); // To separate the output visually
//        account2.DisplayAccountDetails();

//        Console.WriteLine("\nTotal Accounts: " + BankAccount.GetTotalAccounts());
//    }
//}
