namespace ChallengeApp
{
    public class Statistics
    {
        public Statistics()
        {
            this.Sum = 0;
            this.Count = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public float Max { get; private set; }

        public float Min { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Averange 
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverangeLetter 
        {
            get
            {
                switch (this.Averange)
                {
                    case var averange when averange >= 90:
                        return 'A';
                    case var averange when averange >= 70:
                        return 'B'; 
                    case var averange when averange >= 55:
                        return 'C';
                    case var averange when averange >= 40:
                        return 'D';
                    case var averange when averange >= 20:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(this.Max, grade);
            this.Min = Math.Min(this.Min, grade);
        }
    }
}
