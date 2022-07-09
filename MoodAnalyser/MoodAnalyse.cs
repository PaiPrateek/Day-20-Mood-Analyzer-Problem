using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        { }
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        //Creating method for Analyzing the mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("sad"))
                {
                    Console.WriteLine("SAD");
                    return "SAD";
                }
                else
                {
                    Console.WriteLine("HAPPY");
                    return "HAPPY";
                }
            }
            catch
            {
                Console.WriteLine("HAPPY");
                return "HAPPY";
            }

        }
    }
}
