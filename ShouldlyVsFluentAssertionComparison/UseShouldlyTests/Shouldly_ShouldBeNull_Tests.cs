using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldBeNull_Tests
    {
        [Test]
        public void Shouldly_ShouldBeNull_Ref_Test()
        {
            var myRef = "Hello World";
            myRef.ShouldBeNull();
        }

        [Test]
        public void Shouldly_ShouldBeNull_NUllableValue_Test()
        {
            int? nullableValue = 42;
            nullableValue.ShouldBeNull();
        }

        [Test]
        public void Shouldly_ShouldNotBeNull_Ref_Test()
        {
            string? myRef = null;
            myRef.ShouldNotBeNull();
        }
    }
}
