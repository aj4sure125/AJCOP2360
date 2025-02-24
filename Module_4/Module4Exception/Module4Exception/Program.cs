using System;
using System.IO; // Required for file logging

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            long number1 = Convert.ToInt64(input1);
            long number2 = Convert.ToInt64(input2);

            long result = Divide(number1, number2);
            Console.WriteLine($" SUCCESS: {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            string errorMessage = $" ERROR: Invalid input. '{input1}' or '{input2}' is not a valid number.";
            Console.WriteLine(errorMessage);
            LogError(errorMessage, ex);
        }
        catch (DivideByZeroException ex)
        {
            string errorMessage = $" ERROR: Division by zero is not allowed. You entered: {input1} and {input2}.";
            Console.WriteLine(errorMessage);
            LogError(errorMessage, ex);
        }
        catch (OverflowException ex)
        {
            string errorMessage = $" ERROR: The number is too large or too small. You entered: {input1} or {input2}.";
            Console.WriteLine(errorMessage);
            LogError(errorMessage, ex);
        }
        catch (Exception ex)
        {
            string errorMessage = $" ERROR: An unexpected error occurred: {ex.Message}";
            Console.WriteLine(errorMessage);
            LogError(errorMessage, ex);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static long Divide(long a, long b)
    {
        return a / b;
    }

    static void LogError(string message, Exception ex)
    {
        string logMessage = $"{DateTime.Now}: {message}\nException Details: {ex}\n";
        File.AppendAllText("error_log.txt", logMessage);
    }
}