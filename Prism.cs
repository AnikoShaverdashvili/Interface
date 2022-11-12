using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Prism : IShape
    {

        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }



        public Prism(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }



        public double GetArea()
        {
            return 2 *(Width +Length+ Height);
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
