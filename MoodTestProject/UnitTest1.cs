using Mood_Analyzer_Problem;

namespace MoodTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodMessage_ShouldreturnSad()
        {
            //arrange
            Mood moodobj = new Mood();
            string Expectedresult = "Sad";
            //act
            string Actualresult = moodobj.MoodAnalyser("Sad");

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }
    }
}