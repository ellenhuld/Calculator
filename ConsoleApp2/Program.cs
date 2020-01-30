using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcObj = new Calculator();

            //Giver 12
            Console.WriteLine(calcObj.Add(5,7));

            //Giver 20
            Console.WriteLine(calcObj.Add(8));

            //Giver 15
            Console.WriteLine(calcObj.Substrack(5));

            //Giver 30
            Console.WriteLine(calcObj.Multiply(2));

            //Clear; Accumulator = 0
            calcObj.Clear();

            //Skal lægge 5 til 0
            Console.WriteLine(calcObj.Add(5));

        }
    }
}
