using System;

namespace MSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer Problem!");
            MoodAnaLyzer moodAnaLyzer = new MoodAnaLyzer();
            Console.WriteLine(moodAnaLyzer.Mood());
        }
    }
}
