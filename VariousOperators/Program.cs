using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insire número inteiro-não negativo: ");
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
                Console.WriteLine($"Dived by 2: {dividedResult}");
                Console.WriteLine($"Shift left by 3: {shiftedResult}");
                Console.WriteLine($"XOR with 6: {XORResult}");
                Console.WriteLine($"Is greater than 10: {isGreaterThanTen}");
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}