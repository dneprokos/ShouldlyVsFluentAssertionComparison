using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_InRange_Tests
    {
        [Test]
        public void FluentAssertions_ShouldBeInRange_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 300000000 };
            homer.Salary.Should().BeInRange(30000, 40000);
        }

        [Test]
        public void FluentAssertions_ShouldNotBeInRange_Test()
        {
            var mrBurns = new Person { Name = "Mr. Burns", Salary = 30000 };
            mrBurns.Salary.Should().NotBeInRange(30000, 40000);
        }
    }
}
