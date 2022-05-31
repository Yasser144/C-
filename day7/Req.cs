using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class Req:Shape
    {

        public double r2;
       // public double r1;

        public Req(double l,double _length)
        {   // constructor
            Length = l;
            r2 = _length;


        }


        public override double getarea()
        {
            return  Length * r2;
        }
    }
}

