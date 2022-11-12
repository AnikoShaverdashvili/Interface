using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Rectangle : IShape
    {
     

        public int Width { get; set; }
        public int Length { get; set; }


        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
