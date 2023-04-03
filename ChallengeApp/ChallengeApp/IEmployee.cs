namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(int grade);

        Statistics GetStatistics();
    }
}
