using System;

class Customer
{
    public string name;
    private double balance;
    private int accountNumber;

    public Customer(string name, double balance, int accountNumber)
    {
        this.name = name;
        this.balance = balance;
        this.accountNumber = accountNumber;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
}

class Bank
{
    private int bankId;
    private static string bankName = "SBI"; // Changed to static
    private const double MINIMUM_BALANCE = 2000; // Enforcing minimum balance

    public Bank(int bankId)
    {
        this.bankId = bankId;
        Console.WriteLine($"Welcome to {bankName}! Your Bank ID is {bankId}.");
    }

    public void Deposit(Customer customer, double amount)
    {
        if (amount > 0)
        {
            customer.Balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully. New Balance: ₹{customer.Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(Customer customer, double amount)
    {
        if (amount > 0 && (customer.Balance - amount) >= MINIMUM_BALANCE)
        {
            customer.Balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully. New Balance: ₹{customer.Balance}");
        }
        else
        {
            Console.WriteLine($"Withdrawal failed! Minimum balance of ₹{MINIMUM_BALANCE} must be maintained.");
        }
    }

    public void CheckBalance(Customer customer)
    {
        Console.WriteLine($"Account Balance for {customer.Name} (Acc No: {customer.AccountNumber}): ₹{customer.Balance}");
    }
}

class Program
{
    static void Main()
    {
        Bank myBank = new Bank(101);
        Customer customer1 = new Customer("John", 5000, 123456);

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myBank.CheckBalance(customer1);
                    break;
                case "2":
                    Console.Write("Enter amount to deposit: ₹");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    myBank.Deposit(customer1, depositAmount);
                    break;
                case "3":
                    Console.Write("Enter amount to withdraw: ₹");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    myBank.Withdraw(customer1, withdrawAmount);
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the bank services. Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
