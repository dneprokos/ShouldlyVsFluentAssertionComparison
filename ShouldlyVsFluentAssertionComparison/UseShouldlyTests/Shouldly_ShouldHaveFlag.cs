using NUnit.Framework;
using Shouldly.ShouldlyExtensionMethods;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldHaveFlag
    {
        [Test]
        public void Shouldly_ShouldHaveFlag_Enum_Test()
        {
            var actual = Flags.FlagTwo;
            var value = Flags.FlagOne;
            actual.ShouldHaveFlag(value);
        }

        [Test]
        public void Shouldly_ShouldNotHaveFlag_Enum_Test()
        {
            var actual = Flags.FlagTwo;
            var value = Flags.FlagOne;
            actual.ShouldNotHaveFlag(value);
        }
    }
}
