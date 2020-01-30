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
        public double Accumulator { get; private set; }
        
        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        public double Add(double addend)
        {
            Accumulator = Accumulator + addend;
            return Accumulator;
        }

        public double Substrack(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Substrack(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);               
        }

       


    }
}
