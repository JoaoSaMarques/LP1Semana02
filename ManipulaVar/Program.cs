using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main()
        {
            string val;
            int res;
            int res2;

            //Tells user to input a number
            Console.WriteLine("Input a number: ");
            //User input
            val = Console.ReadLine();
            //Convert string into int
            res = Convert.ToInt32(val);
            res2 = res;
            //This line writes a sentence and then does -- to input
            Console.WriteLine(-- res);
            //This line writes a sentence and then does ++ to input
            Console.WriteLine(++ res2);

        }
    }
}

