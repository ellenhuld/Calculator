using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        //hej
       public double _accu{get;set;}

        public double Add(double a, double b)
        {
            _accu=a+b;
            return a + b;
        }

        public double Add(double b)
        {
            _accu=_accu+b;
            return _accu;
        }


        public double Substrack(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        

    }
}
