using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14_DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main()
        {
            decimal oneLightYear = 9450000000000m;

            decimal toStar = (decimal)4.22 * oneLightYear;
            decimal toCenterOfGalaxy = (decimal)26000 * oneLightYear;
            decimal diameterOfMilkyWay = (decimal)100000 * oneLightYear;
            decimal toTheVeryEdge = (decimal)46500000000 * oneLightYear;

            Console.WriteLine("{0:e2}",toStar);
            Console.WriteLine("{0:e2}", toCenterOfGalaxy);
            Console.WriteLine("{0:e2}", diameterOfMilkyWay);
            Console.WriteLine("{0:e2}", toTheVeryEdge);

        }
    }
}
