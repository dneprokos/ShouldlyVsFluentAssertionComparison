using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldNotBe_Tests
    {
        [Test]
        public void FluentAssertions_ShouldNotBe_Objects_Test()
        {
            var theSimpsonsCat = new Dog { Name = "Santas little helper" };
            theSimpsonsCat.Name.Should().NotBe("Santas little helper");
        }

        [Test]
        public void FluentAssertions_ShouldNotBe_Bool_Test()
        {
            const bool myValue = true;
            myValue.Should().NotBe(true, "Some additional context");
        }
    }
}
