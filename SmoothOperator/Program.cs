using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insire número inteiro: ");
            string input = Console.ReadLine();

            sbyte n = sbyte.Parse(input);

            n--;
            Console.WriteLine($"{n}");

            n++;
            Console.WriteLine($"{n}");
        }
    }
}