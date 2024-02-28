using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            while (true)
            {
                // Colocar questão ao utilizador
                Console.Write("Place your question (or type EXIT to quit): ");
                question = Console.ReadLine();

                // Check if the user wants to exit
                if (question.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Exiting the chatbot. Goodbye!");
                    break;
                }
            }
        }
    }
}
