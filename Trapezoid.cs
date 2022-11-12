using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Trapezoid : IShape
    {
   

        public int Base1 { get; set; }
        public int Base2 { get; set; }
        public int Height { get; set; }
        public int Side1 { get; set; }
        public int Side2 { get; set; }


        public Trapezoid(int base1, int base2, int height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public Trapezoid(int base1, int base2, int side1, int side2)
        {
            Base1 = base1;
            Base2 = base2;
            Side1 = side1;
            Side2 = side2;
        }

        public double GetArea()
        {
            return Side1 + Side2 + Base1 + Base2;
        }

        public double GetPerimeter()
        {
            return (Base1 + Base2) / 2 * Height;
        }

    }
}
