using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Print max and min values for various types
            Console.WriteLine($"byte: Max = {byte.MaxValue}, Min = {byte.MinValue}");
            Console.WriteLine($"sbyte: Max = {sbyte.MaxValue}, Min = {sbyte.MinValue}");
            Console.WriteLine($"short: Max = {short.MaxValue}, Min = {short.MinValue}");
            Console.WriteLine($"ushort: Max = {ushort.MaxValue}, Min = {ushort.MinValue}");
        }
    }
}
