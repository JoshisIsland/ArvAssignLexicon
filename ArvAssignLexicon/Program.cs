using ArvAssignLexicon._3._2;

namespace ArvAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing 3.1 Encapsulation
            try
            {
                //Person person1 = new Person(28, "Josefin", "Olsen", 168, 10);
                //Console.WriteLine(person1.Age + person1.FName + person1.LName);

                PersonHandler people = new PersonHandler();

                Person person1 = people.CreatePerson(28, "Josefin", "Olsen", 168, 10);
                Person person2 = people.CreatePerson(10, "Hanna", "Persson", 120, 10);

                Console.WriteLine(person1.toString());
                Console.WriteLine(person2.toString());

            } catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }

            //Testing 3.2 Polymorphism
            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new TextInputError());
            errors.Add(new NoInputError());
            errors.Add(new StupidError());
            errors.Add(new SleepyError());

            foreach (var item in errors)
            {
                Console.WriteLine(item.UEMessage());
            }
        }
    }
}
