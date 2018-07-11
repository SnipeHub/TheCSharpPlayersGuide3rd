using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            remainders work like this.For 23 % 7, we know that 7 goes in to 23 a total of (% means remainder in C#)
            3 whole times. But since 7 * 3 is 21, there will be two left over. In this case, 2 is our remainder.
            */

            int totalApples = 23;
            int people = 7;
            int remainingApples = totalApples % people;  // this will be 2

            Console.WriteLine("23 apples divided by 7, the remainder is: " + remainingApples);

            // For example, the remainder operator can be used to determine if a value is a multiple of another value. If it is, then the remainder operator weill give us 0.
            int totalCars = 20;
            int carBuyers = 4;
            int remainingCars = totalCars % carBuyers;
            Console.WriteLine("Cars unsold: " + remainingCars);

            // try it out section
            int a = 17;
            int b = 4;
            int quotient = a / b; // our division
            int remainder = a % b; // our remainder
            int extraAddition = b * quotient + remainder;

            Console.WriteLine(a + " divided by " + b + " is: " + quotient + ", remainder is: " + remainder);
            Console.WriteLine("Original total of variable a: " + extraAddition);
        }
    }
}
