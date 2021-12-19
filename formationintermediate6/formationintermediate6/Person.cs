using System;

namespace formationintermediate6
{
    public class Person
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
  

        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
