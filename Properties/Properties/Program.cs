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
            private set // This can now be changed only from within this class.
            {
                score = value;
                if (score < 0)
                    score = 0;
            }
        }

        // another way to do the above is like so. This is known as an auto-implemented property.
        public int Score { get; set; }
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

    /// <summary>
    /// Setting the get only makes it writable while the object is being created, but not afterwards.
    /// </summary>
    public class Vector2 // Read-only auto-implemented properties
    {
        public double X { get; }
        public double Y { get; }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    /// <summary>
    /// setting default values. The default value is assigned before the constructor begins, and setting a new value in the constructor will overwrite the default value.
    /// </summary>
    public class Vector3
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
    }
}
