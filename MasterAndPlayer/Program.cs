using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number between 0 and 100.");
            string playerInput1 = Console.ReadLine();

            int n = int.Parse(playerInput1);

            if (n > 0 && n < 100)
            {
                // Will increment number until it reaches 100
                for (int Blanks = 0; Blanks <= 100; Blanks++)
                {
                    //Print 100 Blanks
                    Console.WriteLine(""); 
                }

                Console.WriteLine("Please input a number between 0 and 100.");
                string playerInput2 = Console.ReadLine();
                
            }
            
            else
            {
                Console.WriteLine("Error: Must be between 0 and 100");      
            }

        }
    }
}
