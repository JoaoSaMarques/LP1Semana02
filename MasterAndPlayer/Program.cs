using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask gamemaster for number between 0 and 100
            Console.WriteLine("Please input a number between 0 and 100.");
            string playerInput1 = Console.ReadLine();

            //Convert input to int
            int n = int.Parse(playerInput1);

            //Loop
            if (n > 0 && n < 100)
            {
                // Will increment number of blank lines until it reaches 100
                for (int Blanks = 0; Blanks <= 100; Blanks++)
                {
                    //Print 100 Blanks
                    Console.WriteLine(""); 
                }

                //Ask second user for number between 0 and 100
                Console.WriteLine("Please input a number between 0 and 100.");
                string playerInput2 = Console.ReadLine();

                //Convert input to int
                int i = int.Parse(playerInput2);
                
                //Loop
                if (i > 0 && i < 100)
                {
                    
                }

                // if i < 0 or i > 100
                else
                {
                    Console.WriteLine("Error: Must be between 0 and 100");
                }

            }
            
            // if n < 0 or i > 100
            else
            {
                Console.WriteLine("Error: Must be between 0 and 100");      
            }

        }
    }
}
