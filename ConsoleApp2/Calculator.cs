using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        //public double a { get; private set; }
        //public double b { get; private set; }


        //public Calculator()
        //{
        //    a = 4;
        //    b = 6;

        //}

        public double Add(double a, double b)
        {
            return a + b;
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
