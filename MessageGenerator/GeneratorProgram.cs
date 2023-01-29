namespace MessageGenerator
{
    internal class GeneratorProgram
    {
        public GeneratorProgram()
        {
            while(true)
            {
                Person person = new Person();
                Program.people.Add(person);
                Console.WriteLine(person.Name + " " + person.Age);
                Thread.Sleep(1000);
                new Message();
            }
        }
    }
}