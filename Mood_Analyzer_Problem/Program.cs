namespace Mood_Analyzer_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Enter_Mood;
            Console.WriteLine("Welcome to Mood Analyser Program");
            Console.WriteLine("Enter Mood");
            Enter_Mood = Console.ReadLine();
            MoodAnalyse obj = new MoodAnalyse(Enter_Mood);
            obj.MoodAnalyser();
        }
    }
}