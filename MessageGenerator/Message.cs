using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

namespace MessageGenerator
{
    internal class Message
    {
        static string[] messages = { "Hello", "Bye", "Good", "Cool", "How are you?", "Thanks", "Congratulate" };
        public Message()
        {
            Person sender = Program.people[RandomNumber.Next(Program.people.Count - 1)];
            Person recipient = Program.people[RandomNumber.Next(Program.people.Count - 1)];
            if (!sender.Equals(recipient))
                Console.WriteLine(sender.Name + " send message " + recipient.Name + " : " + messages[RandomNumber.Next(messages.Length - 1)]);
        }
    }
}
