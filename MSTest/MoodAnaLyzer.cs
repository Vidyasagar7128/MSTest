using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    public class MoodAnaLyzer
    {
        string mood = "";
        string myMood = "";

        public MoodAnaLyzer() { }
        public MoodAnaLyzer(string mood)
        {
            this.mood = mood;
        }
        public string analyseMood()
        {
            if (this.mood == "I am in Sad Mood")
                this.myMood = "SAD";
            if (this.mood == "I am in Happy Mood")
                this.myMood = "HAPPY";
            if (this.mood == "I am in Any Mood")
                this.myMood = "HAPPY";
            if (this.mood == "NULL")
                this.myMood = "HAPPY";
            return this.myMood;
        }
    }
}
