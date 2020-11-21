using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AidsTest.Models
{
    class ScoreCounter
    {
        

        private int firstPersonScore;
        private int secondPersonScore;

        public ScoreCounter(List<Question> questions)
        {
            if (questions != null && questions.Count > 0)
                CountResultScore(questions);
        }

        public int FirstPersonScore { get => firstPersonScore; set => firstPersonScore = value; }
        public int SecondPersonScore { get => secondPersonScore; set => secondPersonScore = value; }
        private void CountResultScore(List<Question> questions)
        {
            foreach (Question q in questions)
                CountAnswers(questions.IndexOf(q), q.Answers.Where(s => s.Color.Name == "ffb22222").First().Value);
        }
        private void CountAnswers(int number, int points)
        {
            if (number == 0 || number % 2 == 0)
                FirstPersonScore += points;
            else
                SecondPersonScore += points;
            
        }

    }
}
