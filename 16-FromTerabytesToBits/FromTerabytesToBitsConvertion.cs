using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_FromTerabytesToBits
{
    class FromTerabytesToBitsConvertion
    {
        static void Main()
        {
            var inputTerabyte = double.Parse(Console.ReadLine());

            double convertToByte = (double)inputTerabyte * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(convertToByte);
        }
    }
}
