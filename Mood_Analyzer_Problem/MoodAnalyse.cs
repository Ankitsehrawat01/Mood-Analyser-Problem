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
                if (this.Mood.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");

                }
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
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not Be Null");
            }
            catch (MoodAnalyserCustomException)
            {
                return "Mood Should Not Be Empty";
            }
        }
    }
}
