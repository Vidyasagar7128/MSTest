using System;
using System.Collections.Generic;
using System.Text;

namespace MSTest
{
    public class MoodAnaLyzer
    {
        string myMood = "";
        public string Mood()
        {
            //string mood = Console.ReadLine();
            string mood = "happy";
            if (mood == "sad")
                myMood = "SAD";
            else if(mood == "happy")
                myMood = "HAPPY";
            return myMood;
        }
    }
}
