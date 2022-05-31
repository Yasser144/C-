using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 10);
            Console.WriteLine(rec.getarea());

            Console.WriteLine(rec.Height);
            Console.WriteLine(rec.Length);
            




            Squar seq = new Squar(10);
            Console.WriteLine(seq.getarea());
            Console.WriteLine(seq.Length);



            Console.ReadLine();







        }
    }


    class Rectangle
    {
        private double length;   // Length of a Rectangle

        private double height;   // Height of a Rectangle

        

        public Rectangle(double _length, double _height)
        {   // constructor

            Length = _length;
            Height = _height;


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

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    height = 1;
                else
                    height = value;
            }
        }
        public double getarea()
        {
            return length  * height;
        }
    }

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
