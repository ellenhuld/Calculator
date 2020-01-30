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

            //12
            Console.WriteLine(calcObj.Substrack(20,8));

            //25
            Console.WriteLine(calcObj.Multiply(5,5));

            //64
            Console.WriteLine(calcObj.Power(2,6));

            calcObj.Clear();
            Console.WriteLine("\n");

            //Overload metoder
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

            //Skal lægge 5 til 0 = 5
            Console.WriteLine(calcObj.Add(5));

            //Opløfter i anden = 25
            Console.WriteLine(calcObj.Power(2));

        }
    }
}
