namespace ArvAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(28, "Josefin", "Olsen", 168, 10);
            Console.WriteLine(person1.toString());
        }
    }
}
