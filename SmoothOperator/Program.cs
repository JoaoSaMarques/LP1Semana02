using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer number:");
            string input = Console.ReadLine();
            sbyte n;

            if (sbyte.TryParse(input, out n))
            {
                // Perform decrement and increment
                sbyte decrementResult = (sbyte)(n - 1);
                sbyte incrementResult = (sbyte)(n + 1);

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