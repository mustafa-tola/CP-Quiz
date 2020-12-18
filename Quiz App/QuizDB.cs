using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_App
{
    class QuizDB
    {
        public string[] questions = new string [3] { "Pakistan came into being in the year", "Liaquat Ali Khan was assasinated in", "Allama Iqbal was born in which city" };
        public string[] correctAnswersOptions = new string[3] { "c", "d", "b" };
        public string[,] answers = new string[3, 4]
        {
                {"1950","1945","1947","1943"},
                {"1931","1930","1948","1951"},
                {"Karachi","Sialkot","Lahore","Rawalpindi"}
        };
    }
}
