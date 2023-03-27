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
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("This string is not float");
            }
        }
        public void AddGrade(double grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }

        public void AddGrade(long grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }
        public void AddGrade(char grade)
        {
            string word = grade.ToString();
            if(float.TryParse(word, out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("This Char is not float");
            }

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
