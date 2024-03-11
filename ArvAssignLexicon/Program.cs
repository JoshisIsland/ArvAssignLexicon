namespace ArvAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            
        }
    }
}
