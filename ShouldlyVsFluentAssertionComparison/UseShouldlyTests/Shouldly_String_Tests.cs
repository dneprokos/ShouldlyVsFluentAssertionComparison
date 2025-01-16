using NUnit.Framework;
using Shouldly;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_String_Tests
    {
        [Test]
        public void Shouldly_String_ShouldBe_Test()
        {
            var target = "Homer";
            target.ShouldBe("Bart");
        }

        [Test]
        public void Shouldly_String_ShouldNotBe_Test()
        {
            var target = "Homer";
            target.ShouldNotBe("Bart");
        }

        [Test]
        public void Shouldly_String_ShouldMatch_Test()
        {
            var target = "Homer Simpson";
            target.ShouldMatch("Bart .*");
        }

        [Test]
        public void Shouldly_String_ShouldNotMatch_Test()
        {
            var target = "Homer Simpson";
            target.ShouldNotMatch("Bart .*");
        }

        [Test]
        public void Shouldly_String_Contain_Test()
        {
            var target = "Homer";
            target.ShouldContain("Bart");
        }

        [Test]
        public void Shouldly_String_ShouldContainWithoutWhitespace_Test()
        {
            var target = "Homer Simpson";
            target.ShouldContainWithoutWhitespace(" Bart Simpson ");
        }

        [Test]
        public void Shouldly_String_NotContain_Test()
        {
            var target = "Homer";
            target.ShouldNotContain("Home");
        }

        [Test]
        public void Shouldly_String_BeNull_Test()
        {
            var target = "Homer";
            target.ShouldBeNull();
        }

        [Test]
        public void Shouldly_String_ShouldBeNullOrEmpty_Test()
        {
            var target = "Homer";
            target.ShouldBeNullOrEmpty();
        }

        [Test]
        public void Shouldly_String_ShouldBeEmpty_Test()
        {
            var target = "Homer";
            target.ShouldBeEmpty();
        }

        [Test]
        public void Shouldly_String_ShouldNotBeNull_Test()
        {
            string? target = null;
            target.ShouldNotBeNull();
        }

        [Test]
        public void Shouldly_String_ShouldNotBeNullOrEmpty_Test()
        {
            var target = "";
            target.ShouldNotBeNullOrEmpty();
        }

        [Test]
        public void Shouldly_String_ShouldNotBeEmpty_Test()
        {
            var target = "Homer";
            target.ShouldStartWith("Bart");
        }

        [Test]
        public void Shouldly_String_ShouldStartWith_Test()
        {
            var target = "";
            target.ShouldNotBeNullOrEmpty();
        }

        [Test]
        public void Shouldly_String_ShouldNotStartWith_Test()
        {
            var target = "Homer Simpson";
            target.ShouldNotStartWith("Homer");
        }

        [Test]
        public void Shouldly_String_ShouldEndWith_Test()
        {
            var target = "Homer";
            target.ShouldEndWith("Bart");
        }

        [Test]
        public void Shouldly_String_ShouldNotEndWith_Test()
        {
            var target = "Homer Simpson";
            target.ShouldNotEndWith("Simpson");
        }
    }
}
