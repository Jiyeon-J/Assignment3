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
    class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        private bool _oxygen;

        //Methods
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasMoons()
        {

            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }
    }
    
}
