using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for number that isn't negative or with ","
            Console.WriteLine("Insere número inteiro não-negativo:");
            string a = Console.ReadLine();

            //Convert read into int
            byte n = byte.Parse(a);

            //Decrement the number by 1
            byte result1 = (byte)(n - 1);
            Console.WriteLine(result1);

            //Increment the number by 1
            byte result2 = (byte)(n + 1);
            Console.WriteLine(result2);

        }
    }
}
