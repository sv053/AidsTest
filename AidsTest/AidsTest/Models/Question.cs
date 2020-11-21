using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AidsTest.Models
{
   public class Question
    {
        public string QuestionText { get; set; }
        public ObservableCollection<Answer> Answers { get; set; } = new ObservableCollection<Answer>();
       

        public Question(string t, ObservableCollection<Answer> answers)
        {
            QuestionText = t;
            Answers = answers;
        }

    }
}
