using ArvAssignLexicon._3._2;
using ArvAssignLexicon._3._3;
using System.Runtime.InteropServices;

namespace ArvAssignLexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing 3.1 Encapsulation
            Console.WriteLine("Tests for 3.1: \n");
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
            Console.WriteLine("\n");

            //Testing 3.2 Polymorphism
            Console.WriteLine("Tests for 3.2: \n");
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
            Console.WriteLine("\n");

            //Testing 3.3 More Polymorphism
            Console.WriteLine("Tests for 3.3 + 3.4: \n");
            List<Animal> animals = new List<Animal>();
            Dog fido = new Dog("Fido", 12, 5, true);
            Horse maximus = new Horse("Maximus", 100, 10, true);
            Wolf bob = new Wolf("Bob", 7, 3, false);
            Worm anna = new Worm("Anna", 1.5, 2, 12.4);
            WolfMan jack = new WolfMan("Jack", 65, 30, true);
            animals.Add(fido);
            animals.Add(maximus);
            animals.Add(bob);
            animals.Add(anna);
            animals.Add(jack);

            foreach (var animal in animals)
            {
                if (animal is IPerson hybrid)
                {
                    
                    Console.WriteLine("What does the " + animal.GetType().Name + " say? \n" + hybrid.Talk());
                } else
                {
                    Console.WriteLine("What does the " + animal.GetType().Name + " say? \n" + animal.DoSound());
                }
                
            }

            //F: Detta är en lista med typen dog, därför kan inte en annan typ läggas till, både dog och horse är av typen animal och därför kan de läggas till tillsammmans i en lista med typen animal
            List<Dog> dogs = new List<Dog>();
            //Horse max = new Horse("Max", 120, 6, false);
            //dogs.Add(max);

            //F: Man kommer inte åt metoden HowGoodBoy() från Animals för att den är en Dog specifik metod och inte en som alla av typen Animal har, måste därför typecast för att komma åt enlgti nedan doggie 
            foreach (var animal in animals)
            {
                if (animal is Dog doggie)
                {
                    Console.WriteLine(doggie.name + " is the " + doggie.HowGoodBoy());
                }
                //F: Kommer åt metoden Stats() som finns på animal och alla dess subklasser som överskrivna med specifika addons
                Console.WriteLine(animal.Stats());
            }
        }
    }
}
