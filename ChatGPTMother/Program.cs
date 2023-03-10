using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell you to ask questions
            Console.WriteLine("Ask any questions you may have.");
            //Read input
            string Option = Console.ReadLine();
            //While not exit
            while (Option != "Exit")
            {
                //Available questions with answers
                if (Option == "Are you a robot?")
                    Console.WriteLine("No, I am human.");
                else if (Option == "Tea or Coffee")
                    Console.WriteLine("Coffee...with milk.");
                else if (Option == "Do you understand C?")
                    Console.WriteLine("What's python?");
                else if (Option == "Cats or dogs")
                    Console.WriteLine("Cats");

                //Continue
                Option = Console.ReadLine();
                
            }  

        }
    }
}
