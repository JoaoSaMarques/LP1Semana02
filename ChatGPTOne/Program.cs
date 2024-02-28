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
                // Place your question
                Console.Write("Place your question (or type EXIT to quit): ");
                question = Console.ReadLine();

                // Check if the user wants to exit
                if (question.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Exiting the chatbot. Goodbye!");
                    break;
                }

                // Verify questions
                switch (question)
                {
                    case "How are you?":
                        response = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        response = "One";
                        break;
                    case "What's your mission?":
                        response = "Destroy mankind!";
                        break;
                    case "Are you more intelligent than me?":
                        response = "Obviously!";
                        break;
                    default:
                        response = "You got me, I'm not THAT smart!";
                        break;
                }

                // Responder adequadamente
                Console.WriteLine(response);
            }
        }
    }
}
