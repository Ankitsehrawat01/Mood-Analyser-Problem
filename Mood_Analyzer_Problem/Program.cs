namespace Mood_Analyzer_Problem
{
    public class Program
    {
        public static string Happy_Mood = "I am in happy mood";
        public static string Sad_Mood = "I am in sad mood";
        public static void Main(string[] args)
        {
            bool check = true;
            while(check)
            {
                Console.WriteLine("Welcome To Mood Analyser Problem");
                Console.WriteLine("1) Mood Analyse\n" +
                                  "2) Mood Analyse using Mood as Constructor\n");
                int position = Convert.ToInt32(Console.ReadLine());
                switch(position)
                {
                    case 1:
                        Mood obj = new Mood();
                        obj.MoodAnalyser(Happy_Mood);
                        obj.MoodAnalyser(Sad_Mood);
                        break;
                    case 2:
                        MoodAnalyse obj1 = new MoodAnalyse(Happy_Mood);
                        obj1.MoodAnalyser();
                        MoodAnalyse obj2 = new MoodAnalyse(Sad_Mood);
                        obj2.MoodAnalyser();
                        break;
                }
            }
        }
    }
}