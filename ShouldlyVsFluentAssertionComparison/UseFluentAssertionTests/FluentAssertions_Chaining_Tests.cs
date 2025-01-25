using FluentAssertions;
using NUnit.Framework;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_Chaining_Tests
    {
        [Test]
        public void FluentAssertions_Chaining_And_Test()
        {
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB")
                .And.EndWith("HI")
                .And.Contain("EF")
                .And.HaveLength(9);
        }
    }
}
