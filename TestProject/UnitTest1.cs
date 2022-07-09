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
        //..........................UC1.....................

        //public void Test1()
        //{
        //    //Act
        //    string expected = "HAPPY";
        //    //string message = "I am in any Mood";

        //    MoodAnalyse moodAnalyse = new MoodAnalyse("I am in happy Mood");

        //    //Arrange
        //    string mood = moodAnalyse.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected,mood);
        //}

        //..........................UC2.....................
        //public void Test1()
        //{
        //    //Act
        //    string expected = "HAPPY";
        //    string message = null;

        //    MoodAnalyse moodAnalyse = new MoodAnalyse(message);

        //    //Arrange
        //    string mood = moodAnalyse.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, mood);
        //}

        //..........................UC3.....................

        // Testing for throwing exception for Empty message 
        public void Test1()
        {
            try
            {
                //Act
                string message = " ";

                MoodAnalyse moodAnalyse = new MoodAnalyse(message);

                //Arrange
                string mood = moodAnalyse.AnalyseMood();
            } catch (MoodAnalyserCustomException ex)
            {
                string expected = "Mood Should not be Empty";
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}