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
            if (Mood.ToLower().Contains("sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
            }

            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
        }
    }
}
