using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
  abstract  class Shape
    {
        private double length;   // Length of a Shape





        public Shape(double _length)
        {   // constructor

            Length = _length;


        }
        public Shape()
        {
        }


        // Declare a Code property of type double :

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)

                    length = 1;
                else
                    length = value;
            }
        }

        



        public abstract double getarea();






        public double getlength()
        {
            return length ;
        }
    }
}
