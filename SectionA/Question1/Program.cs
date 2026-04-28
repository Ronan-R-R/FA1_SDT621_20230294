using System;

namespace StudentGradingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prompt the user to enter a student name
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            double[] marks = new double[3];

            // 2 & 3. Prompt the user to enter three subject marks and validate
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i + 1}: ");
                    string input = Console.ReadLine();

                    // Validate that the entered value is numeric
                    if (double.TryParse(input, out double mark))
                    {
                        marks[i] = mark;
                        break; // Exit the loop if input is a valid number
                    }
                    else
                    {
                        // Error message if the user enters letters or symbols
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
            }

            // 4. Calculate the total marks
            double totalMarks = marks[0] + marks[1] + marks[2];

            // 5. Calculate the average marks
            double averageMarks = totalMarks / 3.0;

            // 6 & 7. Determine PASS or FAIL (Rule: Average >= 50 = PASS)
            string resultStatus = averageMarks >= 50 ? "PASS" : "FAIL";

            // Format current date and time to match "09 Apr 2026 15:32:56"
            string issueDate = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            // 8. Display results in the format shown in the screenshot
            Console.WriteLine();
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            
            // Using Math.Round to match the 1 decimal place format seen in the example (e.g. 93,7)
            Console.WriteLine($"Average Marks: {Math.Round(averageMarks, 1)}");
            Console.WriteLine($"Result: {resultStatus}");
            Console.WriteLine($"Result Issued At: {issueDate}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}