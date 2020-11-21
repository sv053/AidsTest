using System;
using System.Collections.Generic;
using System.Text;

namespace AidsTest.Models
{
    class ResultsCount
    {

        public string GeneralText = "Практически не бывает двух людей, мыслящих одинаково и воспринимающих жизнь одинаково. " +
                "Женский взгляд на мир и мужской, безусловно, отличаются. " +
                "Но точки соприкосновения должны быть. И даже при разных мнениях, готовность рассмотреть отношение партнёра к конкретному вопросу и принять его, дорогого стоит. " +
                "Любовь – прекрасное чувство, однако, уважение и дружба – это поддержка, надежда и опора. ";

            private readonly int[][] Score = new int[][] {
                new int[]{ 66, 56, 90,85 },
                new int[]{ 79, 67, 66,63 },
                new int[] { 66, 63, 66,56 },
                new int[] { 79, 75, 79,67 },
                new int[] { 90, 85, 90,80},
        };
        public List<string> ResultTexts = new List<string>()
            {
                "Отсутствие совместимости. Взгляды на жизнь противоположные, вы очень далеки друг от друга. Может быть, не стоит продолжать? Не отчаивайтесь. Ведь есть тот или та, кто Вам гораздо ближе.",
                "Низкая совместимость. Ваше время, проведённое вместе, не приносит радости. Вы разочаровываетесь и расстраиваетесь. Не доказывайте. Не спорьте. Расставание подарит возможность других знакомств. Более удачных.",
                "Средняя совместимость. В чём-то вам хорошо вместе, в чём-то не очень. Если вы друг другу симпатичны, стоит продолжать. Испытываете дискомфорт чаще, чем радость – лучше расстаться.",
            "Хорошая совместимость. У вас много общего, а ваши отличия гармонично дополняют друг друга, без противоречий.Вполне удачный союз.",
            "Отличная совместимость. Вы рядом и вы счастливы. Ваши общие интересы и похожие взгляды на жизнь послужат укреплению ваших отношений и поддержат огонь вашей любви."

            };
            //public static bool Contains(this Range range, int value) => range.Start.Value <= value && value <= range.End.Value;
            //public static bool In(this char c, Range range) => range.Contains(c);
        private bool Contains(int[]  numInt, int checkingNum1, int checkingNum2)
        {
            return checkingNum1 <= numInt[0] && checkingNum1 >= numInt[1] && checkingNum2 <= numInt[2] && checkingNum2 >= numInt[3];
        }

        private int CheckArrayLine(int sum1, int sum2)
        {
          //  int resStringNumber = -1;
        for(int i = 0; i<Score.Length; i++)
            {
                if (Contains(Score[i], sum1, sum2) || (Contains(Score[i], sum2, sum1)))
                    return i;
            }
            return -1;
        }

        public string ChooseResultString(int sum1, int sum2)
        {
            int resText = CheckArrayLine(sum1, sum2);
            return  resText!= -1 ? ResultTexts[resText] : ResultTexts[2];
        }
    }
}
