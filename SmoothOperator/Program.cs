﻿using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a an integer number:");
            string s = Console.ReadLine();
            sbyte n = sbyte.Parse(s);

            // Decremento de N
            Console.WriteLine(n - 1);

            // Incremento de N
            Console.WriteLine(n + 1);
        }
    }
}
