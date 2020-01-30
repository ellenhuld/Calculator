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

            Console.WriteLine( calcObj.Add(5,7) );
            Console.WriteLine( calcObj.Add(8) );

        }
    }
}
