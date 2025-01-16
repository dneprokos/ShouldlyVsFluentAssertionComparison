using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldFlag_Tests
    {
        [Test]
        public void FluentAssertions_ShouldHaveFlag_Enum_Test()
        {
            var actual = Flags.FlagTwo;
            var value = Flags.FlagOne;
            actual.Should().HaveFlag(value);
        }

        [Test]
        public void FluentAssertions_ShouldNotHaveFlag_Enum_Test()
        {
            var actual = Flags.FlagTwo;
            var value = Flags.FlagOne;
            actual.Should().NotHaveFlag(value);
        }
    }
}
