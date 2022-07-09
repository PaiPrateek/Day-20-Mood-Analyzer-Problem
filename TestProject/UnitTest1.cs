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
        //public void Test1()
        //{
        //    try
        //    {
        //        //Act
        //        string message = null;

        //        MoodAnalyse moodAnalyse = new MoodAnalyse(message);

        //        //Arrange
        //        string mood = moodAnalyse.AnalyseMood();
        //    } catch (MoodAnalyserCustomException ex)
        //    {
        //        string expected = "Mood Should Not be Null";
        //        //Assert

        //        Assert.AreEqual(expected, ex.Message);

        //        Assert.AreEqual(expected,ex.Message);

        //    }

        //}

        // Testing for throwing exception for Empty message 
        //public void Test1()
        //{
        //    try
        //    {
        //        //Act
        //        string message = "";

        //        MoodAnalyse moodAnalyse = new MoodAnalyse(message);

        //        //Arrange
        //        string mood = moodAnalyse.AnalyseMood();
        //    }
        //    catch (MoodAnalyserCustomException ex)
        //    {
        //        string expected = "Mood Should not be Empty";
        //        //Assert

        //        Assert.AreEqual(expected, ex.Message);

        //        Assert.AreEqual(expected, ex.Message);

        //    }
        //}

        //..........................UC4.....................

        //Testing for Reflection - MoodAnalyser Class Name Should Return MoodAnalyser Object
        //public void Test1()
        //{
        //    //TC 4.1
        //    string message = null;
        //    object expected = new MoodAnalyse(message);

        //    object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
        //    expected.Equals(obj);

        //}


        //Testing for Reflection - MoodAnalyser Class Name Should Return MoodAnalyser Object
        //public void Test1()
        //{
        //    //TC 4.2
        //    string expected = "Class Not Found";
        //    try
        //    {
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
        //    }catch (MoodAnalyserCustomException exception)
        //    {
        //        Assert.AreEqual(expected, exception.Message);
        //    }
        //}

        //Testing for Reflection - Improper Constructor should throw exception
        //public void Test1()
        //{
        //    //TC 4.3
        //    string expected = "Constructor is Not Found";
        //    try
        //    {
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "Demo");
        //    }
        //    catch (MoodAnalyserCustomException exception)
        //    {
        //        Assert.AreEqual(expected, exception.Message);
        //    }
        //}

        //..........................UC5.....................
        //Testing for Reflection - Improper Constructor should throw exception
        //public void Test1()
        //{
        //    //TC 5.1 - MoodAnalyser Object with Parameter constructor
        //    object expected = new MoodAnalyse("I a in sad mood");

        //    object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "I a in sad mood");

        //    expected.Equals(obj);

        //}

        //public void Test1()
        //{
        //    //TC 5.2 - While passing imprioper class name should throw Exception

        //    string expected = "Class Not Found";
        //    try
        //    {
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "Iam in sad Mood");
        //    }
        //    catch (MoodAnalyserCustomException exception)
        //    {
        //        Assert.AreEqual(expected, exception.Message);
        //    }

        //}

        //public void Test1()
        //{
        //    //TC 5.3 - While passing improper constructor name should throw Exception

        //    string expected = "Constructor is not found";
        //    try
        //    {
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "Demo", "Iam in sad Mood");
        //    }
        //    catch (MoodAnalyserCustomException exception)
        //    {
        //        Assert.AreEqual(expected, exception.Message);
        //    }

        //}

        //..........................UC6.....................
        //public void Test1()
        //{
        //    //UC6 - Using reflection invoking the method AnalyseMood

        //    //Act
        //    string expected = "SAD";
        //    string message = "Iam in Sad Mood";
        //    MoodAnalyse moodAnalyse = new MoodAnalyse(message);
   
        //    //Arrange
        //    string mood = moodAnalyse.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, mood);


        //}

        public void Test1()
        {
            //TC 6.1 - Using reflection invoking the method AnalyseMood by passing message Happy

            //Act
            string expected = "HAPPY";
            string message = "Happy";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);


        }
    }
}