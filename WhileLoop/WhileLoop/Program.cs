using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            int playersNumber = -1; // must be -1 otherwise the while loop would be skipped.

            while (playersNumber < 0 || playersNumber > 10) // this will repeat over and over until you type in a number between 0 and 10.
            {
                Console.WriteLine("\nEnter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }

        }
    }
}
