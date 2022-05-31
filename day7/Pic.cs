using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class Pic
    {

       // public Shape SH { get; set; }

        public Shape[] shapes { get; set; }



       // public double Length { get; set; }
       // public Seq seq { get; set; }
       // public Req req { get; set; }




       // public Pic(Shape[] _sh1)
      //  {
         //   shapes = _sh1;
        //    
      //  }

       //public Pic()
      //  {

      //  }


        public double Totalarea()
        {
            double sum = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                sum += shapes[i].getarea();
            }
            return sum;
        }

    }
}
