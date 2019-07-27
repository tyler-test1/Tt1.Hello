using FluentAssertions;
using NUnit.Framework;
using Tt1.Hello;

namespace Tests
{
    /// <summary>
    /// We don't want to see the test metadata showing up in the generated docs.
    /// </summary>
    public class GreeterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// No sir...  don't want to see this in generated API docs.
        /// </summary>
        /// <param name="nothing"></param>
        [TestCase(null)]
        [TestCase("")]
        public void SayHello_With_Nothing_Just_Says_Hello(string nothing)
        {
            // Arrange
            var sut = new Greeter();

            // Act
            var result = sut.SayHello(nothing);

            // Assert
            result.Should().Be("Hello!");
        }

        [TestCase("Something")]
        [TestCase("Something Else")]
        public void SayHello_With_Something_Says_Hello_Something(string something)
        {
            // Arrange
            var sut = new Greeter();

            // Act
            var result = sut.SayHello(something);

            // Assert
            result.Should().Be($"Hello, {something}!");
        }
    }
}