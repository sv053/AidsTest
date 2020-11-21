using System;
using System.Collections.Generic;
using System.Text;

namespace AidsTest.Models
{
    static class GenderCounter
    {
        private static Random random = new Random();
        private static bool sexStarted = false;
       
         public static bool SexStarted { get => sexStarted; set => sexStarted = value; }

        static GenderCounter()
        {
            SexStarted = DefineStartSex();
        }
        static bool DefineStartSex() => random.Next(0, 2) != 0;

        static bool CountSex(List<Question> quList, Question qu)
        {
            return (quList.IndexOf(qu) == 0 || quList.IndexOf(qu) % 2 == 0)? SexStarted : !SexStarted;
        }

        static string ConvertBoolToString(bool sex) => sex ? "мужчины" : "женщины";

    }
}
