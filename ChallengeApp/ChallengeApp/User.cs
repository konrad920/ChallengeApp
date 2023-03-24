namespace ChallengeApp
{
    public class User
    {  
        private List<int> score = new List<int>();
        public User(string login, string password)
        {
            this .Login = login;
            this .Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
