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
            //Before refactoring

           // double dul, sh, V = 0;
           // Console.Write("Length: ");
           // dul = double.Parse(Console.ReadLine());
           // Console.Write("Width: ");
           // sh = double.Parse(Console.ReadLine());
           // Console.Write("Heigth: ");
           // V = double.Parse(Console.ReadLine());
           // V = (dul + sh + V) / 3;
           // Console.WriteLine("Pyramid Volume: {0:F2}", V);

            //After refactoring

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
