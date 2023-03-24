namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name.ToUpper();
            this.Surname = surname.ToUpper();
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Score
        {
            get
            {
                return scores.Sum();
            }
        }

        public void AddPoints(int number)
        {
            this.scores.Add(number);
        }

        public void WithdrawPoints(int number)
        {
            number = -number;
            this.scores.Add(number);
        }
    }
}
