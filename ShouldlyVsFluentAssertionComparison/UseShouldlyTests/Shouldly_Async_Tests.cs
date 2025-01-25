using NUnit.Framework;
using Shouldly;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_Async_Tests
    {
        [Test]
        public async Task Shouldly_Async_Test()
        {
            // Arrange
            async Task AsyncMethod()
            {
                await Task.Delay(1); // Simulate async operation
                throw new InvalidOperationException("Invalid operation");
            }

            // Act & Assert
            await Should.ThrowAsync<InvalidOperationException>(AsyncMethod);
        }
    }
}
