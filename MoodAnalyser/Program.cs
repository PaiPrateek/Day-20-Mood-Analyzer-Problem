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


            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();

            MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
        }
    }
}
