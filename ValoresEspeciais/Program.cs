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
        }
    }
}
