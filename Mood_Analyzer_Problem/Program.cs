namespace Mood_Analyzer_Problem
{
    public class Program
    {
        public static string Happy_Mood = "I am in happy mood";
        public static string Sad_Mood = "I am in sad mood";
        public static void Main(string[] args)
        {
            Mood obj = new Mood();
            obj.MoodAnalyser(Happy_Mood);
            obj.MoodAnalyser(Sad_Mood);
        }
    }
}