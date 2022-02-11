using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.AbstractFactory
{
    public class AbstractFactoryPattern
    {
        void Main()
        {
            new NavBar(new Android());
            new DropDown(new Apple());
        }
    }
    public class NavBar
    {
        public NavBar(IUIFactory factory) => factory.CreateMyButton();
    }

    public class DropDown
    {
        public DropDown(IUIFactory factory) => factory.CreateMyButton();
    } 

    public class MyButton
    {
        public MyButton(string title, string color) => (Title, Color) = (title, color);

        public string Title { get; set; }
        public string Color { get; set; }
    }
}