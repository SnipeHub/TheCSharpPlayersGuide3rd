using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Fizz = 3;
            int a = 100;

            Console.WriteLine("The FizzBuzz\n");

            // calculations here
            int checkRemainderFizz = Fizz % a;
            Console.WriteLine($"{Fizz} into {a} = {checkRemainderFizz}");

            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
                for (int z = 3; checkRemainderFizz <= 100;) ;
                    Console.Write("Fizz");

                
            }

        }
    }
}
