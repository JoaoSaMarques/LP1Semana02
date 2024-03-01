using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number between 0 and 100");
            string a = Console.ReadLine();

            int n = int.Parse(a);

            while (n > 0 || n < 100)
            {
                if (n < 0 || n > 100)
                {
                    Console.Write("Error");
                    break;
                }
            }

        }
    }
}
