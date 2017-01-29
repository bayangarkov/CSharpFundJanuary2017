using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_IncrementVariable
{
    class IncrementVariable
    {
        static void Main()
        {
            var inputNum = double.Parse(Console.ReadLine());

            double overflowCounter = Convert.ToDouble(Math.Floor(inputNum / 256));

            double formulaForDifference = (inputNum - (overflowCounter * 256));

            if ((inputNum > 0) && (inputNum < 256))
            {
                Console.WriteLine(inputNum);
            }
            else
            {
                Console.WriteLine($"{formulaForDifference}\nOverflowed {overflowCounter} times");
            }

            // The logic is : the given num from the console we devide by 256 to see how many "overflows" we have.
            // Next to check how many leftover digits we have , i multiply the counter * 256. 
            // Then that result is been drawn from inputNumber and the result is how many leftover we have.
        }
    }
}
