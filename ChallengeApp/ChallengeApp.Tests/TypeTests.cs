namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetTwoTheSameIntegerReturnEqualValues()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetTwoTheSameFloatReturnEqualValues()
        {
            //arrange
            float number1 = 5/8;
            float number2 = 5/8;

            //act
            //assert

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetTwoDiffrentDoubleReturnNotEqualValues()
        {
            //arrange
            double number1 = 1.8;
            double number2 = 3.2;

            //act
            //assert

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetTwoTheSameStringReturnEqualValues()
        {
            //arrange
            string word1 = "koza";
            string word2 = "koza";

            //act
            //assert

            Assert.AreEqual(word1, word2);
        }

        [Test]
        public void GetUserReturnTwoDifferentObject()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act
            //assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void IsAgeOfEmploeeIsInteger()
        {
            //arrange
            Employee employ = GetEmployee("Józek", "Jechowicz", 32);

            //act
            //assert
            Assert.IsTrue(employ.Age is int);
        }

        [Test]
        public void IsSurnameOfEmploeeIsNotInteger()
        {
            //arrange
            Employee employ = GetEmployee("Józek", "Jechowicz", 32);

            //act
            //assert
            Assert.IsFalse(employ.Surname is int);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
