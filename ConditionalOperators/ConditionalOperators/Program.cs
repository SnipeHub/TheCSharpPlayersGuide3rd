using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int shields = 50;
            int armor = 20;

            if (shields <= 0 && armor <= 0) // with &&, both must be true in order for the whole expression to be true
                Console.WriteLine("You're dead.");

            if (shields > 0 || armor > 0) // The || operator works in a similar way, though if either one is true, the whole thing becomes true
                Console.WriteLine("You're still alive! Keep going!");
        }
    }
}
