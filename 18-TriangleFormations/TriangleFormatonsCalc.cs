using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_TriangleFormations
{
    class TriangleFormatonsCalc
    {
        static void Main()
        {
            var inputA = int.Parse(Console.ReadLine());
            var inputB = int.Parse(Console.ReadLine()); 
            var inputC = int.Parse(Console.ReadLine()); 

            var sideA = Math.Pow(inputA, 2) + Math.Pow(inputB, 2); // right angle between a and b; A + B == C
            var sideB = Math.Pow(inputB, 2) + Math.Pow(inputC, 2); // right angle between b and c; B + C == A
            var sideC = Math.Pow(inputC, 2) + Math.Pow(inputA, 2); // right angle between c and a; C + A == B


            if (inputA + inputB > inputC && inputA + inputC > inputB && inputB + inputC > inputA)
            {
                if ((inputA == inputB) && (inputA == inputC) && (inputC == inputB))
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has no right angles");
                }
                else if (sideA == Math.Pow(inputC, 2))
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideB == Math.Pow(inputA, 2))
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (sideC == Math.Pow(inputB, 2))
                {
                    Console.WriteLine("Triangle is valid.");
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
