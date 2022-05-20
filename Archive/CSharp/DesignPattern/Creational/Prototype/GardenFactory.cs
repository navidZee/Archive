using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Prototype
{
    public class GardenFactory
    {
        Seed _seed1;
        Seed _seed2;
        Seed _seed3;
        public GardenFactory(Seed seed1,
            Seed seed2,
            Seed seed3)
        {
            this._seed1 = seed1;
            this._seed2 = seed2;
            this._seed3 = seed3;
        }

        internal Seed CreateSeed1() => _seed1.Clone();
        internal Seed CreateSeed2() => _seed2.Clone();
        internal Seed CreateSeed3() => _seed3.Clone();
    }
}