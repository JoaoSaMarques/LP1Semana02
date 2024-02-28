using System;
using System.Xml.XPath;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for number that isn't negative or with ","
            Console.Write("Insere número inteiro não-negativo:");
            string a = Console.ReadLine();

            //Convert read into int
            byte n = byte.Parse(a);

            //Decrement the number by 1
            n--;
            Console.WriteLine(n);

            //Increment the number by 1
            n++;
            Console.WriteLine(n);

            //Divide by 2
            int Divide = n/2;
            Console.WriteLine(Divide);

            //Shift 3 to the left
            int ShiftLeft = n << 3;
            Console.WriteLine(ShiftLeft);

            //Xor with 5?
            int xor = n ^ 5;
            Console.WriteLine(xor);

            //Check if n is bigger than 10
            bool TrueOrFalse = n > 10;
            Console.WriteLine(TrueOrFalse);
        }
    }
}
