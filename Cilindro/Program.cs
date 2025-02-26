using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is the cylinder's height?");
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);

            Console.WriteLine("What is the cylinder's height?");
            string s2 = Console.ReadLine();
            int r = int.Parse(s2);
        }
    }
}
