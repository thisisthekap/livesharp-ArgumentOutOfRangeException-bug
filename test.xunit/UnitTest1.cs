using System.Linq;
using test.lib;
using Xunit;

namespace test.xunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var typeNames = typeof(A).Assembly.GetTypes().Select(t => t.Name).ToList();
            Assert.Contains(typeNames, candidate => candidate == "C");
        }
    }
}