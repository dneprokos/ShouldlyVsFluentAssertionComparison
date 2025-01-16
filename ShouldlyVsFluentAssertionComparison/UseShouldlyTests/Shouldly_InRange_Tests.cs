using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_InRange_Tests
    {
        [Test]
        public void Shouldly_ShouldBeInRange_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 300000000 };
            homer.Salary?.ShouldBeInRange(30000, 40000);
        }

        [Test]
        public void Shouldly_ShouldNotBeInRange_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 30000 };
            mrBurns.Salary?.ShouldNotBeInRange(30000, 40000);
        }
    }
}
