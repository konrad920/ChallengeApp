namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public  string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistics.Averange = 0;
            
            foreach ( var grade in this.grades)
            {
                minimum = Math.Min(minimum, grade);
                maximum = Math.Max(maximum, grade);
                statistics.Averange += grade;
            }
            statistics.Averange /= grades.Count;
            statistics.Max = maximum;
            statistics.Min = minimum;
            return statistics;
        }
    }
}
