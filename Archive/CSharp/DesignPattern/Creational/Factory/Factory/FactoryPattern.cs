using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Factory
{
    public class FactoryPattern
    {
        void Main()
        {
            new NavBar();
            new DropDown();
        }
    }

    public class NavBar
    {
        public NavBar()
        {
            ButtonFactory.CreateMyButton();
        }
    }

    public class DropDown
    {
        public DropDown()
        {
            ButtonFactory.CreateMyButton();
        }
    }

    public class MyButton
    {
        public MyButton(string title, string color) => (Title, Color) = (title, color);

        public string Title { get; set; }
        public string Color { get; set; }
    }
}