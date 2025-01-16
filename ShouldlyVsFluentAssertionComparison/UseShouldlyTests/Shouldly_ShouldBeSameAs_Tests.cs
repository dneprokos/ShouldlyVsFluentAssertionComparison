using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_ShouldBeSameAs_Tests
    {
        [Test]
        public void Shouldly_ShouldBeSameAs_Test()
        {
            var homer1 = new Person { Name = "Homer", Salary = 300000000 };
            var homer2 = new Person { Name = "Homer", Salary = 300000000 };

            homer1.ShouldBeSameAs(homer2);
        }

        [Test]
        public void Shouldly_ShouldNotBeSameAs_Test()
        {
            var homer1 = new Person { Name = "Homer", Salary = 300000000 };
            var homer2 = new Person { Name = "Homer", Salary = 300000000 };

            homer1.ShouldNotBeSameAs(homer2);
        }
    }
}
