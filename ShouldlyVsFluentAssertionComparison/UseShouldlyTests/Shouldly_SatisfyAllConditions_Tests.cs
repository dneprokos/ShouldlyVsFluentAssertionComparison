using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_SatisfyAllConditions_Tests
    {
        [Test]
        public void Shouldly_ShouldSatisfyAllConditions_Test()
        {
            var mrBurns = new Person { Name = null };
            mrBurns.ShouldSatisfyAllConditions(
                                () => mrBurns.Name.ShouldNotBeNullOrEmpty(),
                                () => mrBurns.Name.ShouldBe("Mr.Burns"));
        }

        [Test]
        public void Shouldly_ShouldSatisfyAllConditions_Generic_Test()
        {
            var mrBurns = new Person { Name = null };
            mrBurns.ShouldSatisfyAllConditions(
                                p => p.Name.ShouldNotBeNullOrEmpty(),
                                p => p.Name.ShouldBe("Mr.Burns"));
        }
    }
}
