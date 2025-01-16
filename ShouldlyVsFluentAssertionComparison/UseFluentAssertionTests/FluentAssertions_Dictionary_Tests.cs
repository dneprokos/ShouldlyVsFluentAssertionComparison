using FluentAssertions;
using NUnit.Framework;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_Dictionary_Tests
    {
        [Test]
        public void FluentAssertions_Dictionary_ShouldContainKey_Test()
        {
            var websters = new Dictionary<string, string> { { "Embiggen", "To empower or embolden." } };
            websters.Should().ContainKey("Cromulent");
        }

        [Test]
        public void FluentAssertions_Dictionary_ShouldNotContainKey_Test()
        {
            var websters = new Dictionary<string, string> { { "Embiggen", "To empower or embolden." } };
            websters.Should().NotContainKey("Cromulent");
        }
    }
}
