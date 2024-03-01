using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask gamemaster for number between 0 and 100
            Console.WriteLine("Please put a number between 0 and 100.");
            string playerInput1 = Console.ReadLine();

            //Convert input to int
            int n = int.Parse(playerInput1);

            //Continue if number is between 0 and 100
            if (n > 0 && n < 100)
            {
                // Will increment number of blank lines until it reaches 100
                for (int Blanks = 0; Blanks <= 100; Blanks++)
                {
                    //Print 100 Blanks
                    Console.WriteLine(""); 
                }

                //Main loop
                while (true)
                {
                    Console.WriteLine("Please put a number between 0 and 100.");
                    string playerInput2 = Console.ReadLine();

                    int i = int.Parse(playerInput2);

                    // Does not meet requirements
                    if (i < 0 || i > 100)
                    {
                        Console.WriteLine("Invalid Number!");

                        //This will restart the loop instead or exiting
                        continue;
                    }

                    //If i is higher than n
                    if (i > n)
                    {
                        Console.WriteLine($"The number is lower than {i}.");
                    }

                    //if i is lower than n
                    else if (i < n)
                    {
                        Console.WriteLine($"The number is higher than {i}.");
                    }

                    // if i is equal to n
                    else
                    {
                        Console.WriteLine("Player wins!");
                        break;
                    }
                }
            }

            // Close program is number not between 0 and 100
            else
            {
                Console.WriteLine("Invalid Number!");
            }

        }
    }
}
