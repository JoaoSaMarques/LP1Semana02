using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please ask a question (or type 'EXIT' to quit):");
                string userInput = Console.ReadLine();

                if (userInput.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                string response = GetResponse(userInput);
                Console.WriteLine(response);
            }
        }

        private static string GetResponse(string question)
        {
            // Simple recognition logic for demonstration
            switch (question.ToLower())
            {
                case "how are you?":
                    return "I'm just a program, but thanks for asking!";
                case "what is your name?":
                    return "I am a simple chatbot.";
                case "what can you do?":
                    return "I can answer simple questions!";
                default:
                    return "I'm sorry, I don't recognize that question.";
            }
        }
    }
}