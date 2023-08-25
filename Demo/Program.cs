using Demo.Data;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using var context = new ApplicationDbContext();

            var people = context.People.ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

                person.Age += 10;
                person.Name += " (renamed)";
                person.Sync();
            }

            var modifiedPeople = context.People.ToList();
            foreach (var person in modifiedPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.ReadKey();
        }
    }
}