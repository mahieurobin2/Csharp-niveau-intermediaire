using System;

namespace formationintermediate6
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2001, 12, 08));
            Console.WriteLine(person.Age);
        }
    }
}
