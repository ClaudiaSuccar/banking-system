using System;

namespace banking_system
{
    class Program
    {
        static public string username;
        static public decimal checkings = 1000;
        static public decimal savings = 1000;

        static void Main(string[] args)
        {
            string appName = "Banking System";
            string appVersion = "1.0.0";
            string appAuthor = "Claudia Succar";

            Console.Title = "Banking System";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to {0}!", appName);
            Console.WriteLine("Version: {0}, Author: {1}\n", appVersion, appAuthor);
            Console.ResetColor();

            UserAccount();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nYou have successfully logged into your account, {0}!", username);
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu();
        }

        // User Login
        static void UserAccount()
        {
            
            Console.WriteLine("Enter your username: ");
            username = Console.ReadLine();
            Console.WriteLine("\nPlease enter your account number. (8 digits)");
            string accountNumber = Console.ReadLine();
            while (accountNumber.Length != 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect number of digits. Please try again. (8 digits)");
                Console.ForegroundColor = ConsoleColor.White;
                accountNumber = Console.ReadLine();
            }
        }

        // Main menu
        static void MainMenu()
        {   
            Console.WriteLine("\nYou have accessed the Main Menu.\n" +
                "Enter a number to navigate.\n" +
                "[1]Checkings\n" +
                "[2]Savings\n" +
                "[3]Check Balance\n" +
                "[4]Exit");
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. Please enter a number from 1-4.");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "1":
                    CheckingsAccount();
                    break;
                case "2":
                    SavingsAccount();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYour current balance is\nCheckings: {0}\nSavings: {1}.", checkings, savings);
                    Console.ForegroundColor = ConsoleColor.White;
                    MainMenu();
                    break;
                case "4":
                    ExitProgram();
                    break;
            }
        }

        //Checkings Withdraw
        static void CheckingsWithdraw()
        {
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
            checkings -= withdraw;
            Math.Round(checkings, 2, MidpointRounding.ToEven);
            CheckingsAccount();
        }

        //Chekings Deposit
        static void CheckingsDeposit()
        {
            Console.WriteLine("\nHow much would you like to deposit to checkings?");
            string depositAmount = Console.ReadLine();
            decimal deposit = Decimal.Parse(depositAmount);
            checkings += deposit;
            Math.Round(checkings, 2, MidpointRounding.ToEven);
            CheckingsAccount();
        }

        //Checkings Main
        static void CheckingsAccount()
        {
            Console.WriteLine("\nYou have accessed your Checkings Account.\n" +
                "Your current balance is {0}.\nPlease select an option.\n" +
                "[1] Withdraw\n" +
                "[2] Deposit\n" +
                "[3] Back to Menu\n" +
                "[4] Exit", checkings);
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. Please enter a number from 1-4.");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "1":
                    CheckingsWithdraw();
                    break;
                case "2":
                    CheckingsDeposit();
                    break;
                case "3":
                    MainMenu();
                    break;
                case "4":
                    ExitProgram();
                    break;
            }
        }

        //Savings Withdraw
        static void SavingsWithdraw()
        {
            Console.WriteLine("\nHow much would you like to withdraw from savings?");
            string withdrawAmount = Console.ReadLine();
            decimal withdraw = Decimal.Parse(withdrawAmount);
            while (withdraw > savings)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError, balance will be exceeded. Please try again.");
                Console.ForegroundColor = ConsoleColor.White;
                withdrawAmount = Console.ReadLine();
                withdraw = Decimal.Parse(withdrawAmount);
            }
            savings -= withdraw;
            Math.Round(savings, 2, MidpointRounding.ToEven);
            SavingsAccount();
        }

        //Savings Deposit
        static void SavingsDeposit()
        {
            Console.WriteLine("\nHow much would you like to deposit to savings?");
            string depositAmount = Console.ReadLine();
            decimal deposit = Decimal.Parse(depositAmount);
            savings += deposit;
            Math.Round(savings, 2, MidpointRounding.ToEven);
            SavingsAccount();
        }

        //Savings Main
        static void SavingsAccount()
        {
            Console.WriteLine("\nYou have accessed your Savings Account.\n" +
                "Your current balance is {0}.\nPlease select an option.\n" +
                "[1] Withdraw\n" +
                "[2] Deposit\n" +
                "[3] Back to Menu\n" +
                "[4] Exit", savings);
            string input = Console.ReadLine();
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWrong input. Please enter a number from 1-4.");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
            }
            switch (input)
            {
                case "1":
                    SavingsWithdraw();
                    break;
                case "2":
                    SavingsDeposit();
                    break;
                case "3":
                    MainMenu();
                    break;
                case "4":
                    ExitProgram();
                    break;
            }
        }

        //Exits Program
        static void ExitProgram()
        {
            Console.WriteLine("\nAre your sure you want to exit? [Y/N]");
            string input = Console.ReadLine();
            while(input != "y" && input != "Y" && input != "n" && input != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease enter the correct response. " +
                    "Are you sure you want to exit? [Y/N]");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
            }
            if (input == "y" || input == "Y")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nThank you for using Banking System.\n" +
                    "Have a nice day!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress 'Enter' to exit the application.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (input == "n" || input == "N")
            {
                MainMenu();
            }
        }
    }
}
