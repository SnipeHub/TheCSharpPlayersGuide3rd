using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// A property is simply an easy way to create get and set methods, while still maintaining high readability.
        /// </summary>
        public int score // our score property
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score < 0)
                    score = 0;
            }
        }
    }

    class Time
    {
        private int seconds;

        public int Seconds
        {
            get // if you only have a get block, then the property is read-only
            {
                return seconds; // Seconds is the backing field here...
            }
            set // if you only have a set block, the property would be write-only.
            {
                seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return seconds / 60; // But there's no 'minutes' backing field here.
            }
        }
    }
}
