using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.FactoryMethod
{
    public class FactoryMethodPattern
    {
        void Main()
        {
            new NavBar();
            new DropDown();
            new Apple();
            new Android();
        }
    }

    public class MyButton
    {
        public MyButton(string title, string color) => (Title, Color) = (title, color);

        public string Title { get; set; }
        public string Color { get; set; }
    }
}