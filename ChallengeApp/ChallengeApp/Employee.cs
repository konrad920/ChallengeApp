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
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result) != false)
            {
                AddGrade(result);
            }
            else
            {
                throw new Exception("This string is not float");
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
            switch(grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                case 'F':
                case 'f':
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong letter");
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
            statistics.Averange /= this.grades.Count;
            statistics.Max = maximum;
            statistics.Min = minimum;

            switch(statistics.Averange)
            {
                case var a when a >= 90:
                    statistics.AverangeLetter = 'A';
                    break;
                case var a when a >= 70:
                    statistics.AverangeLetter = 'B';
                    break;
                case var a when a >= 55:
                    statistics.AverangeLetter = 'C';
                    break;
                case var a when a >= 40:
                    statistics.AverangeLetter = 'D';
                    break;
                case var a when a >= 20:
                    statistics.AverangeLetter = 'E';
                    break;
                default:
                    statistics.AverangeLetter = 'F';
                    break;
            }
            return statistics;
        }
    }
}
