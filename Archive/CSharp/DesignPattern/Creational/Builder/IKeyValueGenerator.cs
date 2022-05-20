using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Builder
{
    public interface IKeyValueGenerator
    {
        IKeyValueGenerator Add(string key, string value);
    }
}
