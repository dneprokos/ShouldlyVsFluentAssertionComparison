using NUnit.Framework;
using Shouldly;
using ShouldlyVsFluentAssertionComparison.HelperObjects;

namespace ShouldlyVsFluentAssertionComparison.UseShouldlyTests
{
    public class Shouldly_Enumerable_Tests
    {
        [Test]
        public void Shouldly_Enumerable_ShouldBe_Test()
        {
            var apu = new Person { Name = "Apu" };
            var homer = new Person { Name = "Homer" };
            var skinner = new Person { Name = "Skinner" };
            var barney = new Person { Name = "Barney" };
            var theBeSharps = new List<Person> { homer, skinner, barney };
            theBeSharps.ShouldBe(new[] { apu, homer, skinner, barney });
        }

        [Test]
        public void Shouldly_Enumerable_ShouldBeEmpty_Test()
        {
            var homer = new Person { Name = "Homer" };
            var powerPlantOnTheWeekend = new List<Person> { homer };
            powerPlantOnTheWeekend.ShouldBeEmpty();
        }

        [Test]
        public void Shouldly_Enumerable_ShouldNotBeEmpty_Test()
        {
            var moesTavernOnTheWeekend = new List<Person>();
            moesTavernOnTheWeekend.ShouldNotBeEmpty();
        }

        [Test]
        public void Shouldly_Enumerable_ShouldContain_Test()
        {
            var mrBurns = new Person { Name = "Mr.Burns", Salary = 3000000 };
            var kentBrockman = new Person { Name = "Kent Brockman", Salary = 3000000 };
            var homer = new Person { Name = "Homer", Salary = 30000 };
            var millionaires = new List<Person> { kentBrockman, homer };
            millionaires.ShouldContain(mrBurns);
        }

        [Test]
        public void Shouldly_Enumerable_WithPredicate_Test()
        {
            var homer = new Person { Name = "Homer", Salary = 30000 };
            var moe = new Person { Name = "Moe", Salary = 20000 };
            var barney = new Person { Name = "Barney", Salary = 0 };
            var millionaires = new List<Person> { homer, moe, barney };
            millionaires.ShouldContain(m => m.Salary > 1000000);
        }

        [Test]
        public void Shouldly_Enumerable_ShouldNotContain_Test()
        {
            var homerSimpson = new Person { Name = "Homer" };
            var homerGlumplich = new Person { Name = "Homer" };
            var lenny = new Person { Name = "Lenny" };
            var carl = new Person { Name = "carl" };
            var clubOfNoHomers = new List<Person> { homerSimpson, homerGlumplich, lenny, carl };
            clubOfNoHomers.ShouldNotContain(homerSimpson);
        }

        [Test]
        public void Shouldly_Enumerable_ShouldHaveSingleItem_Test()
        {
            var maggie = new Person { Name = "Maggie" };
            var homer = new Person { Name = "Homer" };
            var simpsonsBabies = new List<Person> { homer, maggie };
            simpsonsBabies.ShouldHaveSingleItem();
        }
    }
}
