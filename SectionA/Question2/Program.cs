using System;
using System.Globalization;

namespace SimpleAtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the main header for the ATM system
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
            Console.WriteLine();

            // 1. Greet the user and ask for their name
            Console.WriteLine("HI , WHAT IS YOUR NAME?");
            string userName = Console.ReadLine();

            // 2. Welcome the user by their name
            Console.WriteLine();
            Console.WriteLine($"WELCOME {userName.ToUpper()}!");

            decimal accountBalance;
            decimal withdrawalAmount;

            // 3. Prompt for and validate the account balance
            while (true)
            {
                Console.Write("Enter account balance: ");
                // Ensure the input is a valid decimal number
                if (decimal.TryParse(Console.ReadLine(), out accountBalance))
                {
                    break; // Exit loop if input is valid
                }
                Console.WriteLine("Invalid input. Please enter a valid number for the balance.");
            }

            // 4. Prompt for and validate the withdrawal amount
            while (true)
            {
                Console.Write("Enter withdrawal amount: ");
                // Ensure the input is a valid decimal number
                if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
                {
                    break; // Exit loop if input is valid
                }
                Console.WriteLine("Invalid input. Please enter a valid number for the withdrawal.");
            }

            Console.WriteLine();

            // 5. Check for sufficient funds before proceeding
            if (withdrawalAmount > accountBalance)
            {
                Console.WriteLine("Transaction failed: Insufficient funds.");
            }
            else
            {
                // 6. Calculate the new balance
                decimal updatedBalance = accountBalance - withdrawalAmount;

                // 7. Get and format the current time for the transaction record
                string transactionTime = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                
                // Set culture to use comma as decimal separator, as seen in the image
                CultureInfo culture = new CultureInfo("en-US");

                // 8. Display the successful transaction details
                Console.WriteLine("Withdrawal successful!");
                // Format the updated balance to two decimal places
                Console.WriteLine($"Updated Balance: {updatedBalance.ToString("N2", culture)}");
                Console.WriteLine($"Transaction Time: {transactionTime}");
            }

            // Wait for user input before closing the application
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}