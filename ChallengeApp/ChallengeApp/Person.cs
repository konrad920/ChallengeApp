namespace ChallengeApp
{
    public abstract class Person
    {
        public Person()
            : this("no name", "no surname", 'N', 0)
        {
        }
        public Person(string name)
            : this(name, "no surname", 'N', 0)
        {
            this.Name = name;
        }
        public Person(string name, string surname)
            : this(name, surname, 'N', 0)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, char gender)
            : this(name, surname, gender, 0)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        public Person(string name, string surname, char gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }

    }
}
