using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // MinAndMax Value of every type
            Console.WriteLine($"Maximum value of sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Minimum value of sbyte: {sbyte.MinValue}");

            Console.WriteLine($"Maximum value of byte: {byte.MaxValue}");
            Console.WriteLine($"Minimum value of byte: {byte.MinValue}");

            Console.WriteLine($"Maximum value of short: {short.MaxValue}");
            Console.WriteLine($"Minimum value of short: {short.MinValue}");

            Console.WriteLine($"Maximum value of ushort: {ushort.MaxValue}");
            Console.WriteLine($"Minimum value of ushort: {ushort.MinValue}");
            
        }
    }
}
