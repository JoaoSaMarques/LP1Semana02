using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a non-negative integer number:");
            string input = Console.ReadLine();
            byte n;

            if (byte.TryParse(input, out n))
            {
                // Perform decrement and increment
                byte decrementResult = (byte)(n - 1);
                byte incrementResult = (byte)(n + 1);

                // Display results
                Console.WriteLine($"Decrement result: {decrementResult}");
                Console.WriteLine($"Increment result: {incrementResult}");
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}