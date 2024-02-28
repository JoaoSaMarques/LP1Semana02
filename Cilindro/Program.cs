using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for height
            Console.WriteLine("Please input a height");
            string First = Console.ReadLine();

            //Convert to double
            double a = double.Parse(First);

            //Ask for Radius
            Console.WriteLine("Please input a radius");
            string Second = Console.ReadLine();

            //Convert to double
            double r = double.Parse(Second);
        }
    }
}
