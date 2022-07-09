using NUnit.Framework;
using MoodAnalyser;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Act
            string expected = "HAPPY";
            //string message = "I am in any Mood";

            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in happy Mood");

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected,mood);
        }
    }
}