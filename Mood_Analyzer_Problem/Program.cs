namespace Mood_Analyzer_Problem
{
    public class Program
    {
        public static string Happy_Mood = "I am in happy mood";
        public static string Sad_Mood = "I am in sad mood";
        public static void Main(string[] args)
        {
            MoodAnalyse obj1 = new MoodAnalyse(Happy_Mood);
            obj1.MoodAnalyser();
            MoodAnalyse obj2 = new MoodAnalyse(Sad_Mood);
            obj2.MoodAnalyser();
        }
    }
}