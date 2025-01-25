using FluentAssertions;
using NUnit.Framework;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_Async_Tests
    {
        [Test]
        public async Task FluentAssertions_Async_Test()
        {
            // Arrange
            async Task AsyncMethod()
            {
                await Task.Delay(1); // Simulate async operation
                throw new InvalidOperationException("Invalid operation");
            }

            // Act & Assert
            await FluentActions.Invoking(() => AsyncMethod())
                .Should().ThrowAsync<InvalidOperationException>()
                .WithMessage("Invalid operation");
        }
    }
}
