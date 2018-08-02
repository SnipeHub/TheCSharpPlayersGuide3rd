using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOutPositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number: ");
            string firstNumberString = Console.ReadLine();
            int firstNumberConvert = Convert.ToInt32(firstNumberString);

            Console.WriteLine("Please input your second number: ");
            string secondNumberString = Console.ReadLine();
            int secondNumberConvert = Convert.ToInt32(secondNumberString);

            // do calculations
            Console.WriteLine("Please wait while we multiply your two inputs...");
            int multiplyInputs = firstNumberConvert * secondNumberConvert;
            Console.ReadKey();

            if (multiplyInputs < 0)
                Console.WriteLine($"The result is negative, your answer is: {multiplyInputs}");
            else if (multiplyInputs > 0)
                Console.WriteLine($"The result is positive, your answer is: {multiplyInputs}");
            else if (multiplyInputs == 0)
                Console.WriteLine($"Well now, technically this is not negative or positive, your answer is zero: {multiplyInputs}");

            Console.ReadKey();
        }
    }
}
