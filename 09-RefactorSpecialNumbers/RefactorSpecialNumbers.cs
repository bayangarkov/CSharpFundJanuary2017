using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main()
        {
            //Before refactoring

            //  int kolkko = int.Parse(Console.ReadLine());
            //  int obshto = 0; int takova = 0; bool toe = false;
            //  for (int ch = 1; ch <= kolkko; ch++)
            //  {
            //      takova = ch;
            //      while (ch > 0)
            //      {
            //          obshto += ch % 10;
            //          ch = ch / 10;
            //      }
            //      toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //      Console.WriteLine($"{takova} -> {toe}");
            //      obshto = 0;
            //      ch = takova;
            //  }s


            //After refactoring

            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                int sumOfNumbers = 0;
                int digits = i;

                while (digits > 0)
                {
                    sumOfNumbers += digits % 10;
                    digits = digits / 10;
                }

                bool isItSpecial = (sumOfNumbers == 5) || (sumOfNumbers == 7) || (sumOfNumbers == 11);
                Console.WriteLine($"{i} -> {isItSpecial}");
            }
        }
    }
}
