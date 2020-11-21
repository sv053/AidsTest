using AidsTest.Models;
using AidsTest.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace AidsTest.ViewModels
{
    class QuestionViewModel : BaseViewModel
    {
       // public static List<Question> QuestionsWithAnswers;
        
      public QuestionViewModel()
        {
       //      QuestionsWithAnswers = new List<Question>();
        //    genderCounter = new GenderCounter();
        }

        public int CheckCoincidences(List<Question> questionsWithAnswers)
        {
            int multOfTwo = 0;

            for (int i = 0; i < 36-1; i++)
            {
                List<Question> bothQuestions = questionsWithAnswers.Where(qwa => qwa.QuestionText == questionsWithAnswers[i].QuestionText).ToList();
                if (bothQuestions.Count == 2)
                {
                    int num1 = bothQuestions[0].Answers.IndexOf(bothQuestions[0].Answers.Where(a => a.Color.Name == "ffb22222").First());
                    int num2 = bothQuestions[1].Answers.IndexOf(bothQuestions[0].Answers.Where(a => a.Color.Name == "ffb22222").First());

                    if (num1 == num2)
                        multOfTwo++;
                }
            }
            return multOfTwo;
        }
        //public void SaveAnswer(Question q)
        //{
        //    QuestionsWithAnswers.Add(q);
            
        //}

        public Question ChangeColor(Question question, Answer answer)
        {
            foreach (var v in question.Answers)
                v.Color = Color.Transparent;
            question.Answers.Where(a => a.AnswerText == answer.AnswerText).First().Color = Color.Firebrick;
            return question;
        }
       
        public Question SetNextQuestion(Question question, List<Question> qList)
        {
            int nextElemNumber = qList.IndexOf(question) + 1;

            if (nextElemNumber > 0 && nextElemNumber < qList.Count)
                //  if (nextElemNumber > 0 && nextElemNumber < 10 && p < 10)
                return qList[nextElemNumber];
            else return null;
        }
       

    }
}
