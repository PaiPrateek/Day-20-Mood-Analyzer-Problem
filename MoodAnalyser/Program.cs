using System;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");
            Console.WriteLine("\n");

            //string message = "I am in any Mood";
            //Passing message in Constructor
            //MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Happy mood");

            //string message = "";
            //MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            //moodAnalyse.AnalyseMood();

            //Reflection
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();

            //Improper Constructor throw exception
            //MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "Demo");

            //While passing imprioper class name should throw Exception
            //MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyser", "MoodAnalyse","I am in Happy mood");

            //While passing imprioper constructor name should throw Exception
            //MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "Demo","I am in Happy mood");

            //Use Reflection to Invoke mood - AnalyseMood
            //MoodAnalyserFactory.InvokeAnalyseMood("Iam in Sad Mood", "AnalyseMood");

            //Use Reflection to Invoke mood - AnalyseMood by passing messgae Happy
            MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
        }
    }
}
