using NUnit.Framework;
using SparkFishChallenge;

namespace SparkFistTest
{
    public class SparkFistTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_Total_Positions()
        {
            //arrange
            var fishChallenge = new SharedClass();
            int FirstNumber = 1;
            int SecondNumber = 10;

            //ACT
            int TotalPositions = fishChallenge.GetTotalNumberOfPositions(FirstNumber, SecondNumber);

            //ASSERT
            Assert.AreEqual(10, TotalPositions);
        }

        [Test]
        public void SecondNumberIsNotHigher()
        {
            var fishChallenge = new SharedClass();
            int FirstNumber = 10;
            int SecondNumber = 9;

            bool isFalse = fishChallenge.IsSecondHigher(FirstNumber, SecondNumber);

            Assert.AreEqual(false, isFalse);


        }

        [Test]
        public void SecondNumberIsHigher()
        {
            var fishChallenge = new SharedClass();
            int FirstNumber = 1;
            int SecondNumber = 9;

            bool isFalse = fishChallenge.IsSecondHigher(FirstNumber, SecondNumber);

            Assert.AreEqual(true, isFalse);
        }
    }
}