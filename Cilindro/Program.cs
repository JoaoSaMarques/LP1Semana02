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

            Console.WriteLine("What is the cylinder's radius?");
            string s2 = Console.ReadLine();
            int r = int.Parse(s2);

            Console.WriteLine("What is the cylinder's volume?");
            string s3 = Console.ReadLine();
            int V = int.Parse(s3);
        }
    }
}
