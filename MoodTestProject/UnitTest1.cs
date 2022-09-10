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
        [TestMethod]
        public void GivenNullMood_ShouldReturnHAPPY()
        {
            //Arrange
            MoodAnalyse moodobj = new MoodAnalyse("Null");
            string Expectedresult = "Happy Mood";
            //Act
            string Actualresult = moodobj.MoodAnalyser();
            //Assert
            Assert.AreEqual(Actualresult, Expectedresult);
        }
        [TestMethod]
        public void GivenNullMood_ShouldthrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                MoodAnalyse moodobj = new MoodAnalyse("null");
                //Act
                string actual = moodobj.MoodAnalyser();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMood_ShouldthrowMoodAnalysisException_IndicatingEmptyMood()
        {
            try
            {
                //Arrange
                MoodAnalyse moodobj = new MoodAnalyse("");
                //Act
                string actual = moodobj.MoodAnalyser();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }
    }
}