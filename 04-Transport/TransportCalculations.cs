using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPeople = int.Parse(Console.ReadLine());

            float capacity = 4 + 8 + 12;

            float sum = inputPeople / capacity;

            Console.WriteLine(Math.Ceiling(sum));
        }
    }
}
