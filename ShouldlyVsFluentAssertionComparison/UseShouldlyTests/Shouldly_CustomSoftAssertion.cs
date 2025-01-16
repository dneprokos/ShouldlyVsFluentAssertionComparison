using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.Extensions;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_CustomSoftAssertion
    {
        [Test]
        public void Shouldly_MultipleAssertions()
        {
            var homer = new Person { Name = "Homer", Salary = 30000 };
            var marge = new Person { Name = "Marge", Salary = 40000 };

            using (var scope = new SoftAssertion())
            {
                scope.Assert(() => homer.Name.ShouldBe("Bart"));
                scope.Assert(() => homer.Salary?.ShouldBeGreaterThan(50000));
                scope.Assert(() => marge.Salary.ShouldBe(50000));
            }
        }
    }
}
