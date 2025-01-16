using FluentAssertions;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_Exceptions_Tests
    {
        [Test]
        public void FluentAssertions_Exceptions_ShouldThrowAction_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 30000 };
            var denominator = 1;
            Action act = () =>
            {
                var y = homer.Salary / denominator;
            };
            act.Should().Throw<DivideByZeroException>();
        }

        [Test]
        public async Task FluentAssertions_Exceptions_ShouldThrowAsync_Test()
        {
            Task doSomething() => Task.CompletedTask;
            Func<Task> act = () => doSomething();
            await act.Should().ThrowAsync<DivideByZeroException>();
        }

        [Test]
        public void FluentAssertions_Exceptions_ShouldThrowFunc_Test()
        {
            Func<Person> act = () => new Person("Homer");
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void FluentAssertions_Exceptions_ShouldNotThrowFunc_Test()
        {
            string? name = null;
            Action act = () => new Person(name!);
            act.Should().NotThrow();
        }
    }
}
