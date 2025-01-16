using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_SatisfyAllConditions_Tests
    {
        [Test]
        public void FluentAssertions_ShouldSatisfyAllConditions_Test()
        {
            var mrBurns = new Person { Name = null };
            mrBurns.Should().Match<Person>(p =>
                !string.IsNullOrEmpty(p.Name) &&
                p.Name == "Mr.Burns", "because it must meet all conditions");
        }

        [Test]
        public void FluentAssertions_ShouldSatisfyAllConditions_Generic_Test()
        {
            var mrBurns = new Person { Name = null };
            mrBurns.Should().Match<Person>(p =>
                !string.IsNullOrEmpty(p.Name) &&
                p.Name == "Mr.Burns", "because it must meet all conditions");
        }
    }
}
