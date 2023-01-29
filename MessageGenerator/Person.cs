using Faker;
namespace MessageGenerator
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Name = Faker.Name.First();
            Age = RandomNumber.Next(0, 100);
        }
    }
}