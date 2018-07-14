using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPrecedence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some simple code for the area of a trapezoid (http://en.wikipedia.org/wiki/Trapezoid)

            double side1 = 5.5;
            double side2 = 3.25;
            double height = 4.6;

            // our calculations
            double side1And2 = side1 + side2;
            double areaOfTrapezoid = (side1 + side2) / 2 * height; // for the answer to be correct, the two numbers in brackets need to be added first before the next calculation.

            Console.WriteLine("Side 1: " + side1 + " + side 2: " + side2 + " = " + side1And2);
            Console.WriteLine("Side 1 and 2: " + side1And2 + " divided by 2 x the height: " + height + ", Your Trapezoid total area is: " + areaOfTrapezoid);
        }
    }
}
