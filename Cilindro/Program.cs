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
            float a = float.Parse(First);

            //Ask for Radius
            Console.WriteLine("Please input a radius");
            string Second = Console.ReadLine();

            //Convert to double
            float r = float.Parse(Second);

            //Volume
            float Volume = MathF.PI * MathF.Pow(r, 2) * a;

            //Surface
            float surfaceArea = 2 * MathF.PI * r * (r + a);

            //print total volume
            Console.WriteLine($"Total volume: " + Volume);
        }
    }
}
