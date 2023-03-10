using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = Convert.ToInt32(Console.ReadLine());
            string message = option switch
            {
                
                1 => "The value is low",
                2 => "Meh... could be better",
                3 => "Hiyo!",
                4 => "KitKat...",
                5 => "HUH?!",
                6 => "FOR THE GLORY OF MANKIND!",
                _ => "What?",
                
            };
            Console.WriteLine(message);
        }
    }
}
