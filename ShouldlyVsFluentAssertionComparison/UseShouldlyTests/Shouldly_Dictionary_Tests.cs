using NUnit.Framework;
using Shouldly;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_Dictionary_Tests
    {
        [Test]
        public void Shouldly_Dictionary_ShouldContainKey_Test()
        {
            var websters = new Dictionary<string, string> { { "Embiggen", "To empower or embolden." } };
            websters.ShouldContainKey("Cromulent");
        }

        [Test]
        public void Shouldly_Dictionary_ShouldNotContainKey_Test()
        {
            var websters = new Dictionary<string, string> { { "Embiggen", "To empower or embolden." } };
            websters.ShouldContainKey("Cromulent");
        }
    }
}
