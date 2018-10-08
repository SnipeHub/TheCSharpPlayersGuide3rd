using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random(); // this is also known as a constructor

            int aRandomNumber = randomGen.Next(6) + 1; // Add one, because Next(6) gives us 0 to 5.
        }
    }
}
