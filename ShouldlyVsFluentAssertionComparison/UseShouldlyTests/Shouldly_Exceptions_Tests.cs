using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_Exceptions_Tests
    {
        [Test]
        public void Shouldly_Exceptions_ShouldThrowAction_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 30000 };
            var denominator = 1;
            Should.Throw<DivideByZeroException>(() =>
            {
                var y = homer.Salary / denominator;
            });
        }

        [Test]
        public async Task Shouldly_Exceptions_ShouldThrowAsync_Test()
        {
            Task doSomething() => Task.CompletedTask;
            var exception = await Should.ThrowAsync<DivideByZeroException>(() => doSomething());
        }

        [Test]
        public void Shouldly_Exceptions_ShouldThrowFunc_Test()
        {
            Should.Throw<ArgumentNullException>(() => new Person("Homer"));
        }

        [Test]
        public void Shouldly_Exceptions_ShouldNotThrowFunc_Test()
        {
            string? name = null;
            Should.NotThrow(() => new Person(name!));
        }
    }
}
