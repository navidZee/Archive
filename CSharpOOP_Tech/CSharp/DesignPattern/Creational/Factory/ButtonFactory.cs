using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Factory
{
    public class ButtonFactory
    {
        public static MyButton CreateMyButton()
        {
            return new MyButton("Submit", "Red");
        }
    }
}
