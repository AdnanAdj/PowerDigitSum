using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number greater than 1000: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1000)
        {
            Console.WriteLine("Invalid input! Number must be greater than 1000.");
            return;
        }

        int result = CalculatePowerSum(n);
        Console.WriteLine($"Output: {result}");
    }

    public static int CalculatePowerSum(int num)
    {
        // Implement your logic here
        return 0; // Replace this with the correct result
    }
}
