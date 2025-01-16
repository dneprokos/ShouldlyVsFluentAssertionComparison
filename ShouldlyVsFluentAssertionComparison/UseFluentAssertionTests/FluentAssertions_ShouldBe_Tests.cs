using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldBe_Tests
    {
        [Test]
        public void FluentAssertions_ShouldBe_Objects_Test()
        {
            var theSimpsonsCat = new Dog { Name = "Santas little helper" };
            theSimpsonsCat.Name.Should().Be("Snowball 2");
        }

        [Test]
        public void FluentAssertions_ShouldBe_Numeric_Test()
        {
            const decimal pi = (decimal)Math.PI;
            pi.Should().BeApproximately(3.24m, 0.01m);
        }

        [Test]
        public void FluentAssertions_ShouldBe_DateTime_Test()
        {
            var date = new DateTime(2000, 6, 1);
            date.Should().BeCloseTo(new DateTime(2000, 6, 1, 1, 0, 1), TimeSpan.FromHours(1));
        }

        [Test]
        public void FluentAssertions_ShouldBe_Bool_Test()
        {
            const bool myValue = false;
            myValue.Should().BeTrue("Some additional context");
        }

        [Test]
        public void FluentAssertions_ShouldBe_Enumerable_Test()
        {
            var apu = new SimpsonCharacter { Name = "Apu" };
            var homer = new SimpsonCharacter { Name = "Homer" };
            var skinner = new SimpsonCharacter { Name = "Skinner" };
            var barney = new SimpsonCharacter { Name = "Barney" };
            var theBeSharps = new List<SimpsonCharacter> { homer, skinner, barney };
            theBeSharps.Should().Equal(new[] { apu, homer, skinner, barney });
        }
    }
}
