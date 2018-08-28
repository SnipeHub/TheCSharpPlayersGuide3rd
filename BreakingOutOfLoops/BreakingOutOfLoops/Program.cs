using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOutOfLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberThatCausesProblems = 54;

            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);

                if (x == numberThatCausesProblems)
                    break;
            }

            while (true)
            {
                Console.WriteLine("What is thy bidding, my master? ");
                string input = Console.ReadLine();

                if (input == "quit" || input == "exit")
                    Console.WriteLine("Yes Master!");
                    break;
            }
        }
    }
}
