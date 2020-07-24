using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
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
