using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main()
        {
            var inputNum = double.Parse(Console.ReadLine());

            var toInt = Convert.ToInt32(Math.Round(inputNum));

            Console.WriteLine(toInt);
        }
    }
}
