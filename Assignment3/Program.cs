using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /*The Author's name: Jiyeon Jeon
     Author's student number: #301103064
     Date last Modified: July 24, 2020
     Program description: GiantPlanet and TerrestrialPlanet
     Revision History: 1.0 created July 24, 2020 Jiyeon 
   */
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
