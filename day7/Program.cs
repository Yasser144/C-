using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape[] sh = new Shape[3];

           ;

            // Shape shh = new Shape(2);


           // Seq s = new Seq();

          
            Seq s1 = new Seq(4);
            Req  r= new Req(2,3);
            Req r2 = new Req(3,4);

            sh[0] = r;
            sh[1] = r2;
            sh[2] = s1;
          

            Pic pic = new Pic();
            pic.shapes = sh;


            Console.WriteLine(pic.Totalarea());
            Console.ReadLine();
           

          /*  pic[0] =  pic.se;
            pic[1] = s;
            p.shapes = pic;
            p.Totalarea();*/



        }
    }
}
