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
    public abstract class Planet
    {
        //create private fields here
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //create public properties here
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount
        { 
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }
        public string Name { get; }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set 
            {
                _ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        //constructor
        public Planet(string name, double diameter, double mass)
        {
            Name = name;
            Diameter = diameter;
            Mass = mass;
        }

        public override string ToString()
        {
            return $"Name: {Name} \tDiameter: {Diameter} \tMass: {Mass}\n";
        }
    }
}
