using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using System;

namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnaLyzer moodAnaLyzer = new MoodAnaLyzer("I am in Sad Mood");
        MoodAnaLyzer moodAnaLyzer1 = new MoodAnaLyzer("I am in Happy Mood");
        MoodAnaLyzer moodAnaLyzer2 = new MoodAnaLyzer("NULL");

        [TestMethod]
        public void TestSad()
        {
            string result = moodAnaLyzer.analyseMood();
            Assert.AreEqual(result, "SAD");
        }/// <summary>
        /// For Sad Mood
        /// </summary>
        [TestMethod]
        public void TestHappy()
        {
            string result = moodAnaLyzer1.analyseMood();
            Assert.AreEqual(result, "HAPPY");
        }/// <summary>
         /// For Happy Mood
         /// </summary>
        [TestMethod]
        public void TestMoodNull()
        {
            try
            {
                string result = moodAnaLyzer2.analyseMood();
                Assert.AreEqual(result, "HAPPY");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }/// <summary>
         /// For Happy Mood Using NULL
         /// </summary>
    }
}
