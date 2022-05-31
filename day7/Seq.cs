using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class Seq : Shape
    {

        public Seq(double _length)
        {   // constructor

            Length = _length;


        }

        public override double getarea()
        {
            return Length*Length;
        }
    }
}