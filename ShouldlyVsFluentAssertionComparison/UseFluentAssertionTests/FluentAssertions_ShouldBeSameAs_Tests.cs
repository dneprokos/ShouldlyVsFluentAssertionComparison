using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_ShouldBeSameAs_Tests
    {
        [Test]
        public void FluentAssertions_ShouldBeSameAs_Test()
        {
            var homer1 = new Person { Name = "Homer", Salary = 300000000 };
            var homer2 = homer1; // Reference equality

            homer1.Should().BeSameAs(homer2);
        }

        [Test]
        public void FluentAssertions_ShouldNotBeSameAs_Test()
        {
            var homer1 = new Person { Name = "Homer", Salary = 300000000 };
            var homer2 = new Person { Name = "Homer", Salary = 300000000 }; // Different instances

            homer1.Should().NotBeSameAs(homer2);
        }
    }
}
