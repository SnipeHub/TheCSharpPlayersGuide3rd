using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylindersProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //pi = 3.1415926f;
            //volume = pi * radius * radius * height;
            //surfaceArea = 2 * pi * radius * (radius + height);

            // Our greeting message.
            Console.WriteLine("Welcome to Cylinder Calculator 1.0!");

            // Read in the cylinder's radius from the user
            Console.Write("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            // Read in the cyliunder's height from the user
            Console.Write("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.141592654;

            // Our calculations using the formulas for a cylinder, under geometry
            // You can find them on Wikipedia: https://en.wikipedia.org/wiki/Cylinder
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            // Now we output the results
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + " square units.");

            // wait for the user to respond before closing...
            Console.ReadKey();
        }
    }
}
