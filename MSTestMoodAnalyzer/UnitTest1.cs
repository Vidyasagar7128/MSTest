using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;

namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnaLyzer moodAnaLyzer = new MoodAnaLyzer();
        [TestMethod]
        public void TestMood()
        {
            string result = moodAnaLyzer.Mood();
            if(result == "SAD")
                Assert.AreEqual(result, "SAD");
            else
                Assert.AreEqual(result, "HAPPY");
        }
    }
}
