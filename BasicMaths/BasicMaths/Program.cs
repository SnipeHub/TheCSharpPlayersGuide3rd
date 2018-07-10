using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths        // Chp 7 Basic maths
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3 + 4;
            int b = 5 - 2;
            int d = 3 + 3;

            Console.WriteLine("3 + 4 = " + a);
            Console.WriteLine("5 - 2 = " + b);

            int c;          // Declaring the variable a. Just remember you must declare the variable before you can use it.
            c = 9 - 2;      // Assigning a value to a, using some math.
            Console.WriteLine(c);

                  // Another assigment.
            Console.WriteLine(d);

            int e = 3 + 1;  // Declaring b and assigning a vlaue to b all at once.
            Console.WriteLine(e);

            int b1 = 1 + 2;      // Assigning a second vlaue to b.
            Console.WriteLine(b1);

            // other examples using letters in place of numbers

            int f = 1;
            int g = f + 4; // 5
            int h = f - g; // -4

            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);

            // chaining many operations together

            int result = 1 + 2 - 3 + 4 - 5 + a - b + c - d;
            Console.WriteLine(result);

            // other examples
            float totalCost = 22.54f; // literal float
            float tipPercent = 0.18f; // remember, this is the same as 18%.
            float tipAmount = totalCost * tipPercent;
            Console.WriteLine(tipAmount);

            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers;  // We're rich ! lol
            Console.WriteLine("Each person gets: $" + moneyPerPerson);

            // Radius calculations

            // The formula for the area of a circle is pi * r ^ 2 (r squared)
            float radius = 4;
            float pi = 3.1415926536f;  // The 'f' makes it a float literal instead of a double literal.
            float area = pi * radius * radius;

            // Using the + operator with strings results in "concatenation".
            Console.WriteLine("The area of the circle is " + area + ".");
        }
    }
}
