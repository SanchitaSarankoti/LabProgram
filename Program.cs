namespace Tutorial4ex2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // NEW CHANGE #1: Added Nationality property
        public string Nationality { get; set; }

        public Person(string name, int age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality; // NEW CHANGE #2: assign nationality
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex", 20, "Nepali");

            Console.WriteLine("Name: " + person1.Name);
            Console.WriteLine("Age: " + person1.Age);

            // NEW CHANGE #3: Added print statement
            Console.WriteLine("Nationality: " + person1.Nationality);
        }
    }
}



