using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigNumber = 1_000_000_000;
            int a = 123_456_789;
            int b = 12_34_56_78_9;
            int c = 1_2__3___4____5;
            double d = 1_000.000_001;

            var message = "Eat my shorts!";
            var number = 47883;
            Console.WriteLine(message);
            Console.WriteLine(number);
        }
    }
}
