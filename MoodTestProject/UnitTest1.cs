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
            MoodAnalyse moodobj = new MoodAnalyse("Sad");
            string Expectedresult = "Sad Mood";
            //act
            string Actualresult = moodobj.MoodAnalyser();

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }
        [TestMethod]
        public void GivenHappyMoodMessage_ShouldreturnHappy()
        {
            //arrange
            MoodAnalyse moodobj = new MoodAnalyse("Happy");
            string Expectedresult = "Happy Mood";
            //act
            string Actualresult = moodobj.MoodAnalyser();

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }
    }
}