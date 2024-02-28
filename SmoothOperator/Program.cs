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
            n--;
            Console.WriteLine(n);

            //Increment the number by 1
            n++;
            Console.WriteLine(n);

        }
    }
}
