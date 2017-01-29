using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNum; i++)
            {
                for (int j = 0; j < inputNum; j++)
                {
                    for (int k = 0; k < inputNum; k++)
                    {
                        var firstLetter = (char)(i + 'a');
                        var secondLetter = (char)(j + 'a');
                        var thirdLetter = (char)(k + 'a');

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");

                    }
                }
            }
        }
    }
}
