using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldGreaterLessThan_Tests
    {
        [Test]
        public void FluentAssertions_ShouldBeGreaterThan_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 30000 };
            mrBurns.Salary.Should().BeGreaterThan(300000000);
        }

        [Test]
        public void FluentAssertions_ShouldBeGreaterThanOrEqual_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 299999999 };
            mrBurns.Salary.Should().BeGreaterThanOrEqualTo(300000000);
        }

        [Test]
        public void FluentAssertions_ShouldBeLessThan_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 300000000 };
            homer.Salary.Should().BeLessThan(30000);
        }

        [Test]
        public void FluentAssertions_ShouldBeLessThanOrEqualTo_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 30001 };
            homer.Salary.Should().BeLessThanOrEqualTo(30000);
        }
    }
}
