using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;

namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnaLyzer moodAnaLyzer = new MoodAnaLyzer("I am in Sad Mood");
        MoodAnaLyzer moodAnaLyzer1 = new MoodAnaLyzer("I am in Happy Mood");

        [TestMethod]
        public void TestSad()
        {
            string result = moodAnaLyzer.analyseMood();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void TestHappy()
        {
            string result = moodAnaLyzer1.analyseMood();
            Assert.AreEqual(result, "HAPPY");
        }
    }
}
