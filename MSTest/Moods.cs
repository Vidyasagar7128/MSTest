using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    public class Moods
    {
        public MoodAnaLyzer mood;
        public Moods(MoodAnaLyzer mood)
        {
            this.mood = mood;
        }
        public Moods() { }
        
        //public string GetMood()
        //{
        //    //string inputMood = Console.ReadLine();
        //    string md = mood.Mood("sad");
        //    Console.WriteLine(md);
        //    return md;
        //}
    }
}
