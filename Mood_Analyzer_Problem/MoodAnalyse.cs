using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyse
    {
        public string Mood;
        public MoodAnalyse(string Mood)
        {
            this.Mood = Mood;
        }
        public string MoodAnalyser()
        {
            try
            {
                if (Mood.ToLower().Contains("sad"))
                {
                    Console.WriteLine("Sad Mood");
                    return "Sad Mood";
                }

                else
                {
                    Console.WriteLine("Happy Mood");
                    return "Happy Mood";
                }
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
    }
}
