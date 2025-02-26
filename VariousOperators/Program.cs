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
                // Perform the math
                byte dividedResult = (byte)(n / 2);
                byte shiftedResult = (byte)(n << 3);
                byte XORResult = (byte)(n ^ 6);

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