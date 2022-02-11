using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.FactoryMethod
{
    public class NavBar : Element
    {
        protected override MyButton CreateMyButton()
        {
            return new MyButton("Click", "Red");
        }
    }
    public class DropDown : Element
    {
        protected override MyButton CreateMyButton()
        {
            return new MyButton("Click-2", "Blue");
        }
    }
    public class Android : Element
    {
        protected override MyButton CreateMyButton()
        {
            return new MyButton("Click-3", "Black");
        }
    }

    public class Apple : Element
    {
        protected override MyButton CreateMyButton()
        {
            return new MyButton("Click-4", "Yellow");
        }
    }
}
