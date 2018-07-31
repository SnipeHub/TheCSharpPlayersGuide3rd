using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddUsingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int scoreOne = 2;

            Console.WriteLine("Please enter a number between 1 & 100: ");
            string userString = Console.ReadLine();
            int convertToInt = Convert.ToInt32(userString);

            int remainderCalculation = convertToInt % scoreOne;

            Console.WriteLine($"The remainder calculation of your input of {convertToInt} remainder {scoreOne} is: {remainderCalculation}");

            if (remainderCalculation == 0)
                Console.WriteLine("The remainder is even");
            else if (remainderCalculation == 1)
                Console.WriteLine("The remainder is odd");

            Console.ReadKey();
                

            
        }
    }
}
