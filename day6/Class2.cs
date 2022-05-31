using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Rectangle
    {
        //double length;   // Length of a Rectangle

        // double height;   // Height of a Rectangle

        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double _length, double _height)
        {   // constructor

            Length = _length;
            Height = _height;


        }


        public Rectangle(Rectangle r) : this(r.Length,r.Height)  { }
        // Declare a Code property of type double :


        public double getarea()
        {
            return Length * Height;
        }

    }
}
