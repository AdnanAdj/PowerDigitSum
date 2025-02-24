using System;

public class DigitPowerSum
{
    public static int CalculateDigitPowerSum(int n)
    {
        // Your recursive code here
        return 0; // Placeholder
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number greater than 2000:");
        if (int.TryParse(Console.ReadLine(), out int input) && input > 2000)
        {
            int result = CalculateDigitPowerSum(input);
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number greater than 2000.");
        }
    }
}
