using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    public delegate float increase(float _amount);
  
    class Employee
    {
        string name { get; set; }


        float sallary { get; set; }

       
        public Employee(string _name, float _salary)
        {
            name = _name;


            sallary = _salary;
        }

        public event increase incssalary;
 
        void Notify(float amount )
        {
            incssalary.Invoke(amount);
    }

    public float aadd(float amount )
    {
        sallary += amount ;
            Notify(amount );
            return sallary;
       //onsole.WriteLine("Addition={0}"+ b);
    }
        public void Sallary()
        {
          
       
           
              Console.WriteLine("sallary" + sallary);
        }


    }




    class Compony
    {
        string name { get; set; }


        float budgett { get; set; }

        
        public Compony(string _name, float _budgett)
        {
            name = _name;


            budgett = _budgett;
        }
        public float deecr(float amount )
        {
            budgett -= amount ;
            return budgett;

        }
        public void Budgett()
        {



            Console.WriteLine("budgett" + budgett);
        }

    }







    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("AHmed", 50);
            Compony booking = new Compony("booking", 50000);
            Compony amazon = new Compony("amazon", 11000);
             

            em.incssalary += booking.deecr;
            em.incssalary += amazon.deecr ;

            // / em.incssalary += booking.deecr();
            // em.incssalary += amazon.deecr(60);


            //   Console.WriteLine("Addition={0}" + booking.);

            em.Sallary();
            booking.Budgett();
            em.aadd(100);

            em.Sallary();
            booking.Budgett();


            //  Console.WriteLine("sallary is" + em.Sallary() );
            //     Console.WriteLine("sallary is" + booking.deecr(50));





            Console.ReadLine();

        


        }
    }
    }
