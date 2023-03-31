namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void IsAverangeCountCorrect()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(2);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.AreEqual(Math.Round(3.3333,2), Math.Round(statistics1.Averange, 2));
        }

        [Test]
        public void IsMaximumReturCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.IsTrue(statistics1.Max == 7);
        }

        [Test]
        public void IsMinimumReturCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(5);
            employee1.AddGrade(2);
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.AreEqual(1.4f, statistics1.Min);
        }

        [Test]
        public void GetZeroValueShouldReturnCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(0);
            employee1.AddGrade(2);
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.IsTrue(statistics1.Min == 0);
        }

        [Test]
        public void GetStringValueAsFloatShouldReturnCorrectMaxValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(0);
            employee1.AddGrade("22");
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.AreEqual(22, statistics1.Max);
        }

        [Test]
        public void GetCharValueShouldReturnCorrectGradeValue()
        {
            //arrange

            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade('b');

            //act

            var statistics1 = employee1.GetStatistics();
            var reward = employee1.GetStatistics().Averange;

            //assert
            Assert.AreEqual(80, reward);
        }

        [Test]
        public void GetSomeAverangeShouldReturnCorrectGradeLetter()
        {
            //arrange

            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade('c');
            employee1.AddGrade(60);
            employee1.AddGrade("90");
            employee1.AddGrade(150);
            employee1.AddGrade('e');

            //act

            var statistics1 = employee1.GetStatistics();

            //assert
            Assert.AreEqual('C', statistics1.AverangeLetter);
        }
    }
}
