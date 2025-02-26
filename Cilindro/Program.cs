using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Prompt for height
            Console.WriteLine("What is the cylinder's height?");
            double a = Convert.ToDouble(Console.ReadLine());

            // Prompt for radius
            Console.WriteLine("What is the cylinder's radius?");
            double r = Convert.ToDouble(Console.ReadLine());

            // Calculate volume
            double V = Math.PI * Math.Pow(r, 2) * a;

            // Calculate surface area
            double areaSuperficie = 2 * Math.PI * r * (r + a);


        }
    }
}
