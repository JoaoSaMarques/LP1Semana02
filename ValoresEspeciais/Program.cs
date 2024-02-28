using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // MinAndMax Value of sbyte
            Console.WriteLine($"Maximum value of sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Minimum value of sbyte: {sbyte.MinValue}");

            // MinAndMax Value of byte
            Console.WriteLine($"Maximum value of byte: {byte.MaxValue}");
            Console.WriteLine($"Minimum value of byte: {byte.MinValue}");

            // MinAndMax Value of short
            Console.WriteLine($"Maximum value of short: {short.MaxValue}");
            Console.WriteLine($"Minimum value of short: {short.MinValue}");

            // MinAndMax Value of ushort
            Console.WriteLine($"Maximum value of ushort: {ushort.MaxValue}");
            Console.WriteLine($"Minimum value of ushort: {ushort.MinValue}");

            // MinAndMax Value of infinity and float for nan INT
            Console.WriteLine($"+ Infin for float: {float.PositiveInfinity}");
            Console.WriteLine($"- Infin for float: {float.NegativeInfinity}");
            Console.WriteLine($"NaN for float: {float.NaN}");

            // MinAndMax Value of infinity and float for nan DOUBLE
            Console.WriteLine($"+ Infin for double: {double.PositiveInfinity}");
            Console.WriteLine($"- Infin for double: {double.NegativeInfinity}");
            Console.WriteLine($"NaN for double: {double.NaN}");
        }
    }
}
