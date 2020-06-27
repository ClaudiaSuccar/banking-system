# Banking System
Command-line banking system, with navigational menus and error handling.

This is a .NET application. Executable file is located in the bin directory.

1. Incorrect inputs are rejected until correct, including not allowing user to exceed balances. Previous menus may also be returned to.
```csharp
    Console.WriteLine("\nHow much would you like to withdraw from checkings?");
    string withdrawAmount = Console.ReadLine();
    decimal withdraw = Decimal.Parse(withdrawAmount);
    while (withdraw > checkings)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nError, balance will be exceeded. Please try again.");
        Console.ForegroundColor = ConsoleColor.White;
        withdrawAmount = Console.ReadLine();
        withdraw = Decimal.Parse(withdrawAmount);
    }
```
![Error Message](error-message.png)

2. Bankers rounding method is utilized to avoid inappropriate currency calculations.
If user would like to withdraw $999.99 out of $1000, the program will respond correctly with $0.01 balance remaining.
```csharp
    static void SavingsDeposit()
    {
        Console.WriteLine("\nHow much would you like to deposit to savings?");
        string depositAmount = Console.ReadLine();
        decimal deposit = Decimal.Parse(depositAmount);
        savings += deposit;
        Math.Round(savings, 2, MidpointRounding.ToEven); //The bankers rounding method
        SavingsAccount();
    }
```
![Bankers Rounding Method](bankers-rounding.png)

3. User is asked to confirm program exit.
![Exiting Program](exit-program.png)
