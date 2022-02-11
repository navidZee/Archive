using System;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Builder
{
    public class BuilderPattern
    {
        void Main()
        {
            HttpHeaderBuilder builder = new HttpHeaderBuilder();
            //QueryBuilder builder = new QueryBuilder();

            ConstructionProcess(builder);
        }
        public void ConstructionProcess(IKeyValueGenerator builder)
        {
            builder.Add("name", "navid")
                .Add("color", "red")
                .Add("age", "21");
        }
    }

    class HttpHeaderBuilder : IKeyValueGenerator
    {
        StringBuilder _queryStringBuilder = new StringBuilder();
        public IKeyValueGenerator Add(string key, string value)
        {
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append(":");
            _queryStringBuilder.Append(value);
            _queryStringBuilder.AppendLine();
            return this;
        }

        public string Build => _queryStringBuilder.ToString();
    }

    class QueryBuilder : IKeyValueGenerator
    {
        StringBuilder _queryStringBuilder = new StringBuilder();
        public IKeyValueGenerator Add(string key, string value)
        {
            _queryStringBuilder.Append(Convert.ToBoolean(_queryStringBuilder.Length) ? "?" : "=");
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append("=");
            _queryStringBuilder.Append(Uri.EscapeDataString(value));
            return this;
        }

        public string Build => _queryStringBuilder.ToString();
    }
}
