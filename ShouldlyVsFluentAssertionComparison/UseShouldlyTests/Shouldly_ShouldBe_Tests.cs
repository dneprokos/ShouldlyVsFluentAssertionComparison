using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldBe_Tests
    {
        [Test]
        public void Shouldly_ShouldBe_Objects_Test()
        {
            var theSimpsonsCat = new Dog { Name = "Santas little helper" };
            theSimpsonsCat.Name.ShouldBe("Snowball 2");
        }

        [Test]
        public void Shouldly_ShouldBe_Numeric_Test()
        {
            const decimal pi = (decimal)Math.PI;
            pi.ShouldBe(3.24m, 0.01m);
        }

        [Test]
        public void Shouldly_ShouldBe_DateTime_Test()
        {
            var date = new DateTime(2000, 6, 1);
            date.ShouldBe(new(2000, 6, 1, 1, 0, 1), TimeSpan.FromHours(1));
        }

        [Test]
        public void Shouldly_ShouldBe_Bool_Test()
        {
            const bool myValue = false;
            myValue.ShouldBe(true, "Some additional context");
            myValue.ShouldBeTrue();
        }

        [Test]
        public void Shouldly_ShouldBe_Enumerable_Test()
        {
            var apu = new SimpsonCharacter { Name = "Apu" };
            var homer = new SimpsonCharacter { Name = "Homer" };
            var skinner = new SimpsonCharacter { Name = "Skinner" };
            var barney = new SimpsonCharacter { Name = "Barney" };
            var theBeSharps = new List<SimpsonCharacter> { homer, skinner, barney };
            theBeSharps.ShouldBe(new[] { apu, homer, skinner, barney });
        }
    }
}
