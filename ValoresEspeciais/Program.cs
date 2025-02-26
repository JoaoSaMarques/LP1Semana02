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
            Console.WriteLine($"int: Max = {int.MaxValue}, Min = {int.MinValue}");
            Console.WriteLine($"uint: Max = {uint.MaxValue}, Min = {uint.MinValue}");
            Console.WriteLine($"long: Max = {long.MaxValue}, Min = {long.MinValue}");
            Console.WriteLine($"ulong: Max = {ulong.MaxValue}, Min = {ulong.MinValue}");
            Console.WriteLine($"float: Max = {float.MaxValue}, Min = {float.MinValue}");
            Console.WriteLine($"double: Max = {double.MaxValue}, Min = {double.MinValue}");
            Console.WriteLine($"decimal: Max = {decimal.MaxValue}, Min = {decimal.MinValue}");

            // Print special values
            Console.WriteLine($"Negative Infinity: {float.NegativeInfinity}, {double.NegativeInfinity}");
            Console.WriteLine($"Positive Infinity: {float.PositiveInfinity}, {double.PositiveInfinity}");
            Console.WriteLine($"NaN: {float.NaN}, {double.NaN}");

            // Test and display result of overflow in uint
            uint overflowTest = uint.MaxValue;
            Console.WriteLine($"Overflow in uint: {overflowTest + 1}"); 

            // Test and display results for float overflow
            float floatOverflowTest = float.MaxValue;
            Console.WriteLine($"Overflow in float (exceeding max): {floatOverflowTest + 1}"); 
            Console.WriteLine($"NaN test: {0f / 0f}"); //This will result in NaN

            // Test and display result of underflow in float
            float floatUnderflowTest = float.MinValue;
            Console.WriteLine($"Underflow in float: {floatUnderflowTest - 1}"); 
        }
    }
}
