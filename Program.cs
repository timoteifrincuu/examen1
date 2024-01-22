namespace examen1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - YearOfBirth; }
        }
    }

    public static class PersonProcessor
    {
        public static Person GetOldestPerson(Person[] people)
        {
            return ;
        }
    }
     
    class Program
    {
        static void Main()
        {
            Console.Write("Nr de persoane= ");
            int numPersons = int.Parse(Console.ReadLine());

            Person[] people = new Person[numPersons];

            for (int i = 0; i < numPersons; i++)
            {
                Console.WriteLine($"Introdu datele pentru persoana {i + 1}");

                Console.Write("Prenume");
                string firstName = Console.ReadLine();

                Console.Write("Nume de familie");
                string lastName = Console.ReadLine();

                Console.Write("Anul nasterii");
                int yearOfBirth = int.Parse(Console.ReadLine());

                people[i] = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    YearOfBirth = yearOfBirth
                };
            }
            Person oldestPerson = PersonProcessor.GetOldestPerson(people);

            Console.WriteLine($"\nPersoana cu varsta cea mai mare e");
            Console.WriteLine($"Prenume: {oldestPerson.FirstName}");
            Console.WriteLine($"Nume de familie: {oldestPerson.LastName}");
            Console.WriteLine($"Varsta: {oldestPerson.Age} ani");

            Console.ReadLine();

        }
    }
}
