namespace ArvAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person1 = new Person(2, "Josefin", "Olsen", 168, 10);
                Console.WriteLine(person1.toString());
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
