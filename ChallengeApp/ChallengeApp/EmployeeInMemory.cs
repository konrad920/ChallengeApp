namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
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
            if (float.TryParse(grade, out float result) != false)
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
        public override Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
