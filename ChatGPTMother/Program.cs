using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask any questions you may have.");
            string Option = Console.ReadLine();
            while (Option != "Exit")
            {
                
                if (Option == "Are you a robot?")
                    Console.WriteLine("No, I am human.");
                else if (Option == "Tea or Coffee")
                    Console.WriteLine("Coffee...with milk.");
                else if (Option == "Do you understand C?")
                    Console.WriteLine("What's python?");
                else if (Option == "Cats or dogs")
                    Console.WriteLine("Cats");

                Option = Console.ReadLine();
                
            }  

        }
    }
}
