using System;

namespace MSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How is your mood!");
            MoodAnaLyzer moodAnaLyzer = new MoodAnaLyzer("I am in Sad Mood");
            moodAnaLyzer.analyseMood();
            Console.WriteLine(moodAnaLyzer.analyseMood());
        }
    }
}
