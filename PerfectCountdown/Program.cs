using System;

class Program
{
    static void Main()
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

            break; // Exit the loop if all conditions are met
        }

        // Countdown logic
        for (int i = start; i >= 0; i -= step)
        {
            Console.WriteLine(i);
        }
    }
}