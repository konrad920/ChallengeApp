using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out var result) != false)
            {
                AddGrade(result);
            }
            else
            {
                throw new Exception("This string is not float");
            }
        }

        public override void AddGrade(char grade)
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
        public override void AddGrade(double grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }

        public override void AddGrade(long grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }

        public override void AddGrade(int grade)
        {
            float value = (float)grade;
            AddGrade(value);
        }

        private List<float> GradesReadFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
                return grades;
            }
            else
            {
                throw new Exception("File does not exists");
            }
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistics.Averange = 0;
            foreach (var grade in grades)
            {
                maximum = Math.Max(maximum, grade);
                minimum = Math.Min(minimum, grade);
                statistics.Averange += grade;
            }
            statistics.Averange /= grades.Count;
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

        public override Statistics GetStatistics()
        {
            var ReadFromFile = this.GradesReadFromFile();
            var result = this.CountStatistics(ReadFromFile);
            return result;
        }
    }
}
