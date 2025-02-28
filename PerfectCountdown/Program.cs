using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int start, step;

            while (true)
            {
                Console.Write("Start number: ");
                start = int.Parse(Console.ReadLine());

                Console.Write("Step number: ");
                step = int.Parse(Console.ReadLine());

                if (start <= 1 || step < 1 || step > start)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }

                if (step >= start)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }

                if (start % step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
            }
        }
    }
}
