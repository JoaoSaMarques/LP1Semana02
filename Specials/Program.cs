using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exe 6
            //Need float for infinity
            float infinityF = 0;

            //Makes infinity positive
            float positive = 1 / infinityF;
            //Writes ∞
            Console.WriteLine(positive);
            //Makes infinity negative
            float negative = -1 / infinityF;
            //Writes -∞
            Console.WriteLine(negative);

            //Need double to tell whether infinity is true for + / -
            double positiveD = double.PositiveInfinity;
            double negativeD = double.NegativeInfinity;

            //Negative infinity = -∞
            Console.WriteLine(negativeD == double.NegativeInfinity);
            //Positive Infinity = ∞
            Console.WriteLine(positiveD == double.PositiveInfinity);


            //Exe 7

            //Int value
            int i = short.MaxValue;
            //Overflow of Int
            Console.WriteLine((short(i + 1)))



        }
    }
}
