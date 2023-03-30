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
            statistics.Averange /= this.grades.Count;
            statistics.Max = maximum;
            statistics.Min = minimum;
            return statistics;
        }

        public Statistics GetStatistickWithForeach()
        {
            var statistick = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistick.Averange = 0;

            foreach ( var grade in this.grades)
            {
                maximum = Math.Max(maximum, grade);
                minimum = Math.Min(minimum, grade);
                statistick.Averange += grade;
            }
            statistick.Max = maximum;
            statistick.Min = minimum;
            statistick.Averange /= this.grades.Count;
            return statistick;
        }

        public Statistics GetStatistickWithFor()
        {
            var statistick = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistick.Averange = 0;

            for ( var grade = 0; grade < this.grades.Count; grade++ )
            {
                maximum = Math.Max(maximum, this.grades[grade]);
                minimum = Math.Min(minimum, this.grades[grade]);
                statistick.Averange += this.grades[grade];
            }
            statistick.Max = maximum;
            statistick.Min = minimum;
            statistick.Averange /= this.grades.Count;
            return statistick;
        }

        public Statistics GetStatistickWithDoWhile()
        {
            var statistick = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistick.Averange = 0;

            int index = 0;
            do
            {
                maximum = Math.Max(maximum, this.grades[index]);
                minimum = Math.Min(minimum, this.grades[index]);
                statistick.Averange += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistick.Max = maximum;
            statistick.Min = minimum;
            statistick.Averange /= this.grades.Count;
            return statistick;
        }

        public Statistics GetStatistickWithWhile()
        {
            var statistick = new Statistics();
            float maximum = float.MinValue;
            float minimum = float.MaxValue;
            statistick.Averange = 0;

            int index = 0;
            while(index < this.grades.Count)
            {
                maximum = Math.Max(maximum, this.grades[index]);
                minimum = Math.Min(minimum, this.grades[index]);
                statistick.Averange += this.grades[index];
                index++;
            }
            statistick.Max = maximum;
            statistick.Min = minimum;
            statistick.Averange /= this.grades.Count;
            return statistick;
        }
    }
}
