using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Picture
    {
       
        Rectangle r1, r2;
        public Rectangle R1
        {
            set
            {
                r1 = new Rectangle(value);
            }
            get
            {
                return new Rectangle(r1);
            }
        }

        public Rectangle R2
        {
            set
            {
                r2 = new Rectangle(value);
            }
            get
            {
                return new Rectangle(r2);
            }
        }
       

       
        public Squar S { get; set; }

        public Squar[] squar { get; set; }

        public double Length { get; set; }

       


        public Picture(Rectangle _r1, Rectangle _r2, Squar[] _s)
        {
            R1 = _r1;
            R2 = _r2;
            squar = _s;

        }

        public Picture()
        {

        }


        public void  gettotarea()

        {
            double area = 0;

            for (int i = 0; i <squar.Length; i++)
            {
                area += squar[i].getarea();
            }

            area += R2.getarea(); 
            area += R1.getarea();


            Console.WriteLine( area) ;
        



       
        
        }


    }
}
