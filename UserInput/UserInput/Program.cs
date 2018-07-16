using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatTheUserTyped = Console.ReadLine(); // to capture user input data and place inside the string variable
            int aNumber = Convert.ToInt32(whatTheUserTyped); // to convert into an integer

            Console.WriteLine("You typed the following: " + whatTheUserTyped);

            // Other examples
            bool b = false;
            int i = Convert.ToInt32(b);

            double d = 3.4;
            float f = Convert.ToSingle(d);
        }
    }
}
