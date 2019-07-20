using System;

namespace Tt1.Hello
{
    public class Greeter
    {
        public string SayHello(string name=null)
        {
            var effectiveName = string.IsNullOrWhiteSpace(name) ? string.Empty : $", {name}";
            return $"Hello{effectiveName}!";
        }
    }
}
