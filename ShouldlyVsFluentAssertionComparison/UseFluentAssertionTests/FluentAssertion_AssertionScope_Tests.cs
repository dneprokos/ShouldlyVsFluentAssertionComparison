using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertion_AssertionScope_Tests
    {
        [Test]
        public void ShouldValidateUserDetails()
        {
            // Arrange
            var user = new Person
            {
                Id = 1,
                Name = "John",
                Salary = 3000
            };

            // Act & Assert
            using (new AssertionScope())
            {
                user.Name.Should().NotBeNullOrEmpty("because Name is required");
                user.Id.Should().BeGreaterThanOrEqualTo(1, "because id should be greater than 0");
                user.Salary.Should().BeInRange(1500, 6000, "because we can pay only in a range 1500-6000");
            }
        }
    }
}
