using System;

namespace Tt1.Hello
{
    /// <summary>
    /// A cute little class that you can use to greet you.
    /// </summary>
    public class Greeter
    {
        /// <summary>
        /// Says hello.
        /// </summary>
        /// <param name="name">The name of the entity to which the greeting will be made.</param>
        /// <returns></returns>
        public string SayHello(string name=null)
        {
            var effectiveName = string.IsNullOrWhiteSpace(name) ? string.Empty : $", {name}";
            return $"Hello{effectiveName}!";
        }

        /// <summary>
        /// Here's a new class method description.
        /// </summary>
        public void NotImplementedYet()
        {
            throw new NotImplementedException();
        }
    }
}
