using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main()
        {
            double length, width, volume = 0.0d;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            volume = double.Parse(Console.ReadLine());

            double formulaForVolume = ((length * width * volume) / 3);

            Console.WriteLine("Pyramid Volume: {0:F2}", formulaForVolume);

        }
    }
}
