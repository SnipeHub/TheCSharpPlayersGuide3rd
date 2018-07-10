using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTraingleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 5;
            double h = 6;
            double bh = (b * h); // 30
            double area = bh / 2; // 15

            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
