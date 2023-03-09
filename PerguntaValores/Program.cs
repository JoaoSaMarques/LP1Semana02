using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main()
        {

            //Will wait for the input of the height of the cylinder
            Console.WriteLine("Enter Height of Cylinder: ");
            //Will convert the string of the height into a double
            double Height = Convert.ToDouble(Console.ReadLine());
            //will wait for the input of the radius of the cylinder
            Console.WriteLine("Enter Radius of Cylinder: ");
            //will convert the string of the radius into a double
            double Radius = Convert.ToDouble(Console.ReadLine());

            //Math for the volume of the cylinder
            double Volume = Math.PI * (Radius * Radius) * Height;
            //Math for the area of the cylinder
            double Area = 2 * Math.PI * Radius * (Radius * Height);
            
            //Write the result of the height
            Console.WriteLine("Volume of cylinder: " + Volume);
            //Write the result of the surface
            Console.WriteLine("Surface of the cylinder: " + Area);

            //Make a variable that equals the radius
            var squareNumber = Radius;
            //Square root of radius
            squareNumber= Math.Pow(squareNumber,2);
            //Write the result of the square root
            Console.WriteLine("Square of R is: " + squareNumber);

        }
    }
}
