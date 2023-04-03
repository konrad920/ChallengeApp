namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
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
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    AddGrade(90);
                    break;
                case "5":
                    AddGrade(85);
                    break;
                case "-5":
                case "5-":
                    AddGrade(80);
                    break;
                case "+4":
                case "4+":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(70);
                    break;
                case "-4":
                case "4-":
                    AddGrade(65);
                    break;
                case "+3":
                case "3+":
                    AddGrade(60);
                    break;
                case "3":
                    AddGrade(55);
                    break;
                case "-3":
                case "3-":
                    AddGrade(50);
                    break;
                case "+2":
                case "2+":
                    AddGrade(45);
                    break;
                case "2":
                    AddGrade(40);
                    break;
                case "-2":
                case "2-":
                    AddGrade(35);
                    break;
                case "+1":
                case "1+":
                    AddGrade(30);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong grade");
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
            switch (grade)
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

            foreach (var grade in this.grades)
            {
                minimum = Math.Min(minimum, grade);
                maximum = Math.Max(maximum, grade);
                statistics.Averange += grade;
            }
            statistics.Averange /= this.grades.Count;
            statistics.Max = maximum;
            statistics.Min = minimum;

            switch (statistics.Averange)
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
