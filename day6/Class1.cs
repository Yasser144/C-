using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Squar
    {
        private double length;   // Length of a Squar





        public Squar(double _length)
        {   // constructor

            Length = _length;


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



        public double getarea()
        {
            return length * length;
        }
    }
}
