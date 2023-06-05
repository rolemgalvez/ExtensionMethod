using HomeworkTwentyNine.Library.Models;
using static HomeworkTwentyNine.Library.Extensions.PersonExtension;
using System;

namespace HomeworkTwentyNine.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.SetName("Juan Dela Cruz").SetDefatulAge().PrintInfo();

            Console.ReadLine();
        }
    }
}
