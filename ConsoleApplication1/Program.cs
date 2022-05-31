using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction c = new Fraction(1, 4);
            Fraction c1 = new Fraction(2, 3);
            Fraction c2 = new Fraction(3, 4);
           

           
            Fraction res = (c1 + c2);
            res.Print();
            
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);
           
            Fraction plus = c1++;
            plus.Print();
            Console.ReadLine();
        }
    }
}
