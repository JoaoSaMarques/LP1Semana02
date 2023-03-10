using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input a number: ");
            string val = Console.ReadLine();
           

            for (int res= Convert.ToInt32(val);
            res > res + 2; res++)
                Console.WriteLine("x"); 
        }
    }
}
