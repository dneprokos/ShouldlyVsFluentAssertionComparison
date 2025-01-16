using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldNotBe_Tests
    {
        [Test]
        public void Shouldly_ShouldNotBe_Objects_Test()
        {
            var theSimpsonsCat = new Dog { Name = "Santas little helper" };
            theSimpsonsCat.Name.ShouldNotBe("Santas little helper");
        }

        [Test]
        public void Shouldly_ShouldNotBe_Bool_Test()
        {
            const bool myValue = true;
            myValue.ShouldNotBe(true, "Some additional context");
        }
    }
}
