using System;
using Xunit;
using logic;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = "Hello yosuke";
            var actual = HelloWorld.GetMessage("yosuke");
            Assert.Equal(expected, actual);
        }
    }
}
