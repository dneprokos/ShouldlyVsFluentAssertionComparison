using FluentAssertions;
using NUnit.Framework;

namespace ShouldlyVsFluentAssertionComparison.UseFluentAssertionTests
{
    public class FluentAssertions_String_Tests
    {
        [Test]
        public void FluentAssertions_String_ShouldBe_Test()
        {
            var target = "Homer";
            target.Should().Be("Bart");
        }

        [Test]
        public void FluentAssertions_String_ShouldNotBe_Test()
        {
            var target = "Homer";
            target.Should().NotBe("Bart");
        }

        [Test]
        public void FluentAssertions_String_ShouldMatch_Test()
        {
            var target = "Homer Simpson";
            target.Should().MatchRegex("Bart .*");
        }

        [Test]
        public void FluentAssertions_String_ShouldNotMatch_Test()
        {
            var target = "Homer Simpson";
            target.Should().NotMatchRegex("Bart .*");
        }

        [Test]
        public void FluentAssertions_String_Contain_Test()
        {
            var target = "Homer";
            target.Should().Contain("Bart");
        }

        [Test]
        [Ignore("Not found equivalent method in Fluent Assertion")]
        public void FluentAssertions_String_ShouldContainWithoutWhitespace_Test()
        {          
        }

        [Test]
        public void FluentAssertions_String_NotContain_Test()
        {
            var target = "Homer";
            target.Should().NotContain("Home");
        }

        [Test]
        public void FluentAssertions_String_BeNull_Test()
        {
            var target = "Homer";
            target.Should().BeNull();
        }

        [Test]
        public void FluentAssertions_String_ShouldBeNullOrEmpty_Test()
        {
            var target = "Homer";
            target.Should().BeNullOrEmpty();
        }

        [Test]
        public void FluentAssertions_String_ShouldBeEmpty_Test()
        {
            var target = "Homer";
            target.Should().BeEmpty();
        }

        [Test]
        public void FluentAssertions_String_ShouldNotBeNull_Test()
        {
            string? target = null;
            target.Should().NotBeNull();
        }

        [Test]
        public void FluentAssertions_String_ShouldNotBeNullOrEmpty_Test()
        {
            var target = "";
            target.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void FluentAssertions_String_ShouldNotBeEmpty_Test()
        {
            var target = "Homer";
            target.Should().NotBeEmpty();
        }

        [Test]
        public void FluentAssertions_String_ShouldStartWith_Test()
        {
            var target = "Homer";
            target.Should().StartWith("Bart");
        }

        [Test]
        public void FluentAssertions_String_ShouldNotStartWith_Test()
        {
            var target = "Homer Simpson";
            target.Should().NotStartWith("Homer");
        }

        [Test]
        public void FluentAssertions_String_ShouldEndWith_Test()
        {
            var target = "Homer";
            target.Should().EndWith("Bart");
        }

        [Test]
        public void FluentAssertions_String_ShouldNotEndWith_Test()
        {
            var target = "Homer Simpson";
            target.Should().NotEndWith("Simpson");
        }
    }
}
