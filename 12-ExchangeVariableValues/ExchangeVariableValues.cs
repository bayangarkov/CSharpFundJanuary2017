using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;

            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
