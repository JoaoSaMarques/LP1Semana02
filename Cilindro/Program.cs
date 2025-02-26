using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is the cylinder's height?");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the cylinder's radius?");
            double r = Convert.ToDouble(Console.ReadLine());

            double V = Math.PI * Math.Pow(r, 2) * a;

        }
    }
}
