namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void IsMinusValueGradeReturnCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(3.5f);
            employee1.AddGrade(-2.4f);
            employee1.AddGrade(6);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.IsTrue(statistics1.Min < 0);
        }

        [Test]
        public void IsAverangeCountCorrect()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.IsTrue(statistics1.Averange == 5);
        }

        [Test]
        public void IsMaximumReturCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(7);
            employee1.AddGrade(-2);
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.IsTrue(statistics1.Max == 7);
        }

        [Test]
        public void GetMaxFloatValueShouldReturnCorrectValue()
        {
            //arrange
            Employee employee1 = new Employee("Konrad", "Sowizral");
            employee1.AddGrade(float.MaxValue);
            employee1.AddGrade(-2);
            employee1.AddGrade(1.4f);

            //act

            var statistics1 = employee1.GetStatistics();

            //assert

            Assert.AreEqual(statistics1.Max, float.MaxValue);
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
    }
}
