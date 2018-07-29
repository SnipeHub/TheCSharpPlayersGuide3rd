using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassPi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instead of creating a variable and sotring your value when finding the radius of a circle with Pi, we can do the following with the Math.PI class.

            double radius = 3;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the Circle is: {area}");

            // You'll likely find more uses for pi than e.

            double eSquared = Math.E * Math.E;
            Console.WriteLine($"{eSquared}");
        }
    }
}
