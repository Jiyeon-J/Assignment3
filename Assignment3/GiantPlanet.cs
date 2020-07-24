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
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type)
        : base(name, diameter, mass)
        {
            _type = type;
        }

        public bool HasMoons()
        {
            if(MoonCount>0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public bool HasRings()
        {
            if(RingCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
