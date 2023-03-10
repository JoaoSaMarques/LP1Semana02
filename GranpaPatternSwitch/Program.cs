using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert answer to int
            int option = Convert.ToInt32(Console.ReadLine());
            //Type first part to print second part
            string message = option switch
            {
                //Options
                1 => "The value is low",
                2 => "Meh... could be better",
                3 => "Hiyo!",
                4 => "KitKat...",
                5 => "HUH?!",
                6 => "FOR THE GLORY OF MANKIND!",
                _ => "What?",
                
            };
            //Print first part asked
            Console.WriteLine(message);
        }
    }
}
