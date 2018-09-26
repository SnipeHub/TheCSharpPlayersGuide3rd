using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program // You should only overload methods when you are trying to do the exact same kind of thing with different
                 // kinds of data
    {
        /// <summary>
        /// Print our methods to console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int doMaths = Multiply(30, 12);
            Console.WriteLine($"The first method with two numbers: {doMaths}");

            float doMaths2 = Multiply(10.56f, 4.22f, 44.67f);
            Console.WriteLine($"The same method but with 3 numbers: {doMaths2}");
        }

        // Method overloading works when you use a different signature
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }

        // or the same parameters as long as the type was different
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static double Multiply(double a, double b, double c)
        {
            return (a + b) * c;
        }

        /// <summary>
        /// The following two wont work as the signature is the same
        /// </summary>
        /// <param name="a"> the first number to multiply</param>
        /// <param name="b">The second number to multiply</param>
        /// <returns> The product of the two input numbers</returns>
        static int WontWork(int a, int b)
        {
            return a * b;
        }

        static int WontWork(int c, int d)
        {
            return c * d;
        }
    }
}
