using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.AbstractFactory
{
    public class Android : IUIFactory
    {
        public MyButton CreateMyButton()
        {
            return new MyButton("Submit", "Red");
        }
    }

    public class Apple : IUIFactory
    {
        public MyButton CreateMyButton()
        {
            return new MyButton("Send", "Blue");
        }
    }
}
