using System;
using System.Collections.Generic;
using CSharpOOP_Tech;

namespace Archive.CSharp.DesignPattern.Structural.Composite.FirstDemo
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}