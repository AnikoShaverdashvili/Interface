using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Triangle : IShape
    {
        public int BaseLine { get; set; }
        public int Height { get; set; }  

        public int Side1 { get; set; }   

        public int Side2 { get; set; }

        public Triangle(int baseLine, int height, int side1, int side2)
        {
            BaseLine = baseLine;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }

 

        public double GetArea()
        {
            return (Height * BaseLine) / 2;
        }

        public double GetPerimeter()
        {

            return BaseLine + Side1 + Side2;
         }
    }
}
