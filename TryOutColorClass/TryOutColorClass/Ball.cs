using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutColorClass
{
    class Ball
    {
        private Color color;
        private float radius;
        private int timesthrown;

        /// <summary>
        /// Creates a new ball with a given size and color.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="radius"></param>
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesthrown = 0;
        }

        /// <summary>
        /// Pops the ball, changing it's size to 0.
        /// </summary>
        public void Pop()
        {
            radius = 0;
        }

        /// <summary>
        /// Throws the ball. This will increment the count
        /// of the number of times the ball has been thrown only
        /// if the ball has not been popped.
        /// </summary>
        public void Throw()
        {
            if (radius > 0)
            {
                timesthrown++;
            }
        }

        /// <summary>
        /// Returns the number of times that the ball has been thrown
        /// so far. This will be updated whenever the Throw method is
        /// called.
        /// </summary>
        /// <returns></returns>
        public int GetTimesThrown()
        {
            return timesthrown;
        }
    }
}
