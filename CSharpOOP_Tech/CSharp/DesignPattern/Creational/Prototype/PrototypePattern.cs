using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Prototype
{
    public class PrototypePattern
    {
        void Main()
        {
            var garden = new GardenFactory(
                new TreeSeed("Apple"),
                new FlowerSeed("Roses"),
                new GrassSeed("Roses")
            );

            garden.CreateSeed1();
            garden.CreateSeed2();
            garden.CreateSeed3();
        }
    }

    public class TreeSeed : Seed
    {
        public string Type { get; set; }
        public TreeSeed(string type) => Type = type;

        public override Seed Clone() => new TreeSeed(Type);
    }

    public class GrassSeed : Seed
    {
        public string Type { get; set; }
        public GrassSeed(string type) => Type = type;

        public override Seed Clone() => new GrassSeed(Type);
    }

    public class FlowerSeed : Seed
    {
        public string Type { get; set; }
        public FlowerSeed(string type) => Type = type;

        public override Seed Clone() => new FlowerSeed(Type);
    }

}