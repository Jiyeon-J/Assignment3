using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116460, 5.683e26, "gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus",12104,4.867e24,false);
            Console.WriteLine(terrestrialPlanet.ToString());
        }

        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
