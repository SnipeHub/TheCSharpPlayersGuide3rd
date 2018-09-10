using System;

namespace FizzBuzzTry
{
    public class Program
    {
        public static void Main()
        {
            // the goal is to replace multiples of 3 with the word Fizz and multiples of 5 with Buzz. Then replace multiple of both 3 and 5 (15 or 30) with "FizzBuzz".
            int i;

            Console.WriteLine("The FizzBuzz Challenge!\n");

            for (i = 1; i <= 100; ++i) // ++i will increment the value of i, and return the incremented value. i++ will increment i, but return the original value of i held before being incremented.
            {
                if (i % 15 == 0) // To print our multiples of 15
                
                    Console.WriteLine("FizzBuzz 15"); // printed 15 so you can see the multiples in action
                
                if (i % 9 == 0) // Just added an extra check for experimenting, not necessary
                
                    Console.WriteLine("FizzBuzz 9");
       
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz 3");

                else if (i % 5 == 0)
                    Console.WriteLine("Buzz 5");

                else
                    Console.WriteLine(i);
            }
        }
    }
}
