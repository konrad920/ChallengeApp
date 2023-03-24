namespace ChallengeApp.Tests
{
    public class UserTests
    {

        [Test]
        public void WhenUseerCollectScores_ShouldSumCorrect()
        {
            //arrange
            var user = new User("Konrad", "csvs34");
            user.AddScore(5);
            user.AddScore(3);

            //act

            int result = user.Result;

            //assert

            Assert.AreEqual(8, result);
        }
    }
}