using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSwitchCalc
{
    public class SwitchCalc
    {
        public static void StayCheck()
        {
            double result = 0.0;

        
                Console.WriteLine("Please enter you first number: ");
                string firstNumberString = Console.ReadLine();
                double firstNumberNew = Convert.ToDouble(firstNumberString);

                Console.WriteLine("Please enter your second number: ");
                string secondNumberString = Console.ReadLine();
                double secondNumberNew = Convert.ToDouble(secondNumberString);

                Console.WriteLine("What would you like to do with these numbers, please choose your operator symbol +, -, *, /: ");
                char inputString = Console.ReadKey().KeyChar;

                Console.WriteLine($"You entered: {firstNumberNew} {inputString} {secondNumberNew}");



                // Maths
                switch (inputString)
                {
                    case '+':
                        result = firstNumberNew + secondNumberNew;
                        break;
                    case '-':
                        result = firstNumberNew - secondNumberNew;
                        break;
                    case '*':
                        result = firstNumberNew * secondNumberNew;
                        break;
                    case '/':
                        result = firstNumberNew / secondNumberNew;
                        break;
                    default:
                        Console.WriteLine("Invalid entry, try again");
                        break;
                }

                // output
                Console.WriteLine($"Your Answer is: {result}");
                Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SwitchCalc.StayCheck();
        }
    }
}
