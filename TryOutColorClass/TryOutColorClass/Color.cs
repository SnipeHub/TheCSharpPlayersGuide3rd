using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutColorClass
{
    class Color
    {
        /// <summary>
        /// Stores our component of colors.
        /// </summary>
        private int red;
        private int green;
        private int blue;
        private int alpha;

        /// <summary>
        /// Creates a new color with all of the components specified.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        /// <summary>
        /// Creates a new color with only red, green and blue components
        /// specified. In this case, alpha will be 255, or completely opaque.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        /// <summary>
        /// Sets the red component of this color.
        /// </summary>
        /// <returns></returns>
        public int GetRed()
        {
            return red;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int GetBlue()
        {
            return blue;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public int GetGrayscale()
        {
            return (int)((red + green + blue) / 3);
        }
    }
}
