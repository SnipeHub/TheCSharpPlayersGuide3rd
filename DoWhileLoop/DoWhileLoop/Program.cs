using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // remember with the while loop, it will first check the condition to see if it is met, if not, it can skip it. With the do-while, the loop will always be executed at least once.
            int playersNumber;

            do
            {
                Console.WriteLine("Enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }
            while (playersNumber < 0 || playersNumber > 10);
        }
    }
}
