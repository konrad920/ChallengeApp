namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmplyeeCollectVariousScores_ShouldSumCorrect()
        {
            //arrange
            var employee = new Employee("Konrad", "Kowalski", 29);
            employee.AddPoints(5);
            employee.AddPoints(3);
            employee.WithdrawPoints(4);
            employee.WithdrawPoints(2);
            employee.AddPoints(4);

            //act

            int result = employee.Score;

            //assert

            Assert.AreEqual(6, result);
        }


        [Test]
        public void WhenEmplyeeWithdrawScores_ShouldSumCorrect()
        {
            //arrange
            var employee = new Employee("Józef", "Kowalski", 32);
            employee.WithdrawPoints(7);
            employee.WithdrawPoints(3);

            //act

            int result = employee.Score;

            //assert

            Assert.AreEqual(-10, result);
        }

        [Test]
        public void WhenEmplyeeCollectScores_ShouldSumCorrect()
        {
            //arrange
            var employee = new Employee("Anna", "Martias", 19);
            employee.AddPoints(4);
            employee.AddPoints(5);

            //act

            int result = employee.Score;

            //assert

            Assert.AreEqual(9, result);
        }
    }
}
