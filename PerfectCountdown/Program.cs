using System;

class Program
{
    static void Main()
    {
        // Define variables as int for both inside and outside loop.
        int start, step;

        // Loop
        while (true)
        {
            // Ask for start input.
            Console.Write("Start number: ");
            start = int.Parse(Console.ReadLine());

            // ask for step input
            Console.Write("Step number: ");
            step = int.Parse(Console.ReadLine());

            // If start is smaller than or equal to 1.
            // if step is smaller than 1.
            // if step is higher than start.
            if (start <= 1 || step < 1 || step > start)
            {
                Console.WriteLine("Out-of-range start or step. Try again.");
                continue;
            }

            // Checks if step is higher than or equal to start.
            if (step >= start)
            {
                Console.WriteLine("Start must be higher than step. Try again.");
                continue;
            }

            // Checks if start is divisible by step.
            if (start % step != 0)
            {
                Console.WriteLine("Start not divisible by step. Try again.");
                continue;
            }

            // Finish the loop after successfully finishing.
            break; 
        }

        // Countdown logic until i reaches 0.
        // i = start, and while it's >= than 0 per number, start -= step.
        // i is reduced by step per iteration.
        for (int i = start; i >= 0; i -= step)
        {
            Console.WriteLine(i);
        }
    }
}