﻿using System;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");
            Console.WriteLine("\n");

            //string message = "I am in any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in sad mood");
            moodAnalyse.AnalyseMood();
        }
    }
}
