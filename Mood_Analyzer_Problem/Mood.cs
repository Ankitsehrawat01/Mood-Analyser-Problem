using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class Mood
    {
        public string MoodAnalyser(string Mood)
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
