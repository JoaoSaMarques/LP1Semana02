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

            byte result = (byte)(n - 1);
            Console.WriteLine(result);

        }
    }
}
