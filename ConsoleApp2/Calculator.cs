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
        //hej
        public double Accumulator { get; private set; }
        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            if (Accumulator == 0)
            {
                return a + b;
            }
            else 
            return Accumulator + b;
        }

        public double Substrack(double a, double b)
        {
            if (Accumulator == 0)
            {
                return a - b;
            }
            else
                return Accumulator - b;
        }

        public double Multiply(double a, double b)
        {
            if (Accumulator == 0)
            {
                return a * b;
            }
            else
                return Accumulator * b;
        }

        public double Power(double a, double b)
        {
            if (Accumulator == 0)
            {
                return Math.Pow(a, b);
            }
            else
                return Accumulator
            
        }

       


    }
}
