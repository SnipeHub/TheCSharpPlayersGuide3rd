using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopContinue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                if (x == 3)
                {
                    continue;
                }
                Console.WriteLine(x);
            }
        
        }
    }
}
