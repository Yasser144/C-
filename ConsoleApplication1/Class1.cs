using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fraction
    {



        int numerator;
       int denominator;


        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                
                    numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                    denominator = 1;
                else
                    denominator = value;
                
            }
        }

        public Fraction(int _numerator, int _denominator)
        {
            Numerator = _numerator;
            Denominator = _denominator;
        }

        public Fraction(Fraction c)
        {
            numerator = c.numerator;
            denominator = c.denominator;

        }

        public static Fraction operator+ (Fraction a, Fraction b)
        {
            int r1 = (int)a.numerator * b.denominator + (int)b.numerator * a.denominator;
            int r2 = (int)a.denominator * b.denominator;
            return new Fraction(r1, r2);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (decimal)a.numerator * b.denominator == (decimal)b.numerator * a.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (!(a == b));
        }

        public static Fraction operator ++(Fraction c) // -- 
        {
            int r1 = (int)c.numerator + c.denominator;
            int r2 = (int)c.denominator;
            return new Fraction(r1, r2);
        }

        public void Print()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }




    }
}
