using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main()
        {
            string val;
            int res;

            //Tells user to input a number
            Console.WriteLine("Input a number: ");
            //User input
            val = Console.ReadLine();
            //Convert string into int
            res = Convert.ToInt32(val);
            //This line writes a sentence and then does -- to input
            Console.WriteLine("-- behind value: ", -- res);
            //This line writes a sentence and then does ++ to input
            Console.WriteLine("++ behind value_ ", ++ res);

        }
    }
}

