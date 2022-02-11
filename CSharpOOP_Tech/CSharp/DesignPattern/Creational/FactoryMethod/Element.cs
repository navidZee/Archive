using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.FactoryMethod
{
    public abstract class Element
    {
        protected abstract MyButton CreateMyButton();

        public Element() => CreateMyButton();
    }
}
