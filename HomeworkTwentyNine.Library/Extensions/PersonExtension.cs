using HomeworkTwentyNine.Library.Models;
using System;

namespace HomeworkTwentyNine.Library.Extensions
{
    public static class PersonExtension
    {
        public static PersonModel SetName(this PersonModel person, string name)
        {
            person.Name = name;
            return person;
        }

        public static PersonModel SetDefatulAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }

        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.Name} ({person.Age} years old)");
        }
    }
}
