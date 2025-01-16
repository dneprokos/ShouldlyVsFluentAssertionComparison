using FluentAssertions;
using NUnit.Framework;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldBeNull_Tests
    {
        [Test]
        public void FluentAssertions_ShouldBeNull_Ref_Test()
        {
            var myRef = "Hello World";
            myRef.Should().BeNull();
        }

        [Test]
        public void FluentAssertions_ShouldBeNull_NullableValue_Test()
        {
            int? nullableValue = 42;
            nullableValue.Should().BeNull();
        }

        [Test]
        public void FluentAssertions_ShouldNotBeNull_Ref_Test()
        {
            string? myRef = null;
            myRef.Should().NotBeNull();
        }
    }
}
