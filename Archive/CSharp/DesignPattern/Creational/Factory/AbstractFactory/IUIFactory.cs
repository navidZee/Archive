using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.AbstractFactory
{
    public interface IUIFactory
    {
        public MyButton CreateMyButton();
    }
}
