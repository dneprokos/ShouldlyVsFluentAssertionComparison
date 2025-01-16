using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldGreaterLessThan_Tests
    {
        [Test]
        public void Shouldly_ShouldBeGreaterThan_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 30000 };
            mrBurns.Salary?.ShouldBeGreaterThan(300000000);
        }

        [Test]
        public void Shouldly_ShouldBeGreaterThanOrEqual_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 299999999 };
            mrBurns.Salary?.ShouldBeGreaterThanOrEqualTo(300000000);
        }

        [Test]
        public void Shouldly_ShouldBeLessThan_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 300000000 };
            homer.Salary?.ShouldBeLessThan(30000);
        }

        [Test]
        public void Shouldly_ShouldBeLessThanOrEqualTo_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 30001 };
            homer.Salary?.ShouldBeLessThanOrEqualTo(30000);
        }
    }
}
