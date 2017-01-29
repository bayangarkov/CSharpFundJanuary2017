using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int num = 1; num <= inputNum; num++)
            {
                var currentNumber = num;
                var sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True",currentNumber);
                }
                else
                {
                    Console.WriteLine("{0} -> False",currentNumber);
                }

            }
        }
    }
}
