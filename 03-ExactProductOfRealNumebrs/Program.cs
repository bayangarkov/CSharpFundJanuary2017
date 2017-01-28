using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            decimal finalSUm = 1m;

            for (int i = 0; i < inputNum; i++)
            {
                decimal inputFromLoop = decimal.Parse(Console.ReadLine());

                finalSUm = finalSUm * inputFromLoop;
            }

            Console.WriteLine(finalSUm);
        }
    }
}
