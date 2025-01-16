namespace ShouldlyVsFluentAssertionComparison.HelperObjects
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal? Salary { get; set; }
    }
}
