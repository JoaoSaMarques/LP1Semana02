using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insire número inteiro-não negativo: ");
            string input = Console.ReadLine();
            byte n;

            if (byte.TryParse(input, out n))
            {
                // Perform the math
                byte dividedResult = (byte)(n / 2);
                byte shiftedResult = (byte)(n << 3);
                byte XORResult = (byte)(n ^ 6);
                bool isGreaterThanTen = n > 10;

                // Display results
                Console.WriteLine($"{dividedResult}");
                Console.WriteLine($"{shiftedResult}");
                Console.WriteLine($"{XORResult}");
                Console.WriteLine($"{isGreaterThanTen}");
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}