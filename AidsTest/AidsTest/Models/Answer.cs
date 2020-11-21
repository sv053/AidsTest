using AidsTest.ViewModels;
using System.ComponentModel;
using System.Drawing;


namespace AidsTest.Models
{
   public class Answer : BaseViewModel
    {
        public string AnswerText { get; set; } = "motya";
        public int Value;
        public bool Result;
             
        public Color Color { get => color; set => SetProperty(ref color, value); }

        private Color color;
     //   public
        public Answer(string s, int v)
        {
            AnswerText = s;
            Value = v;
        }
        
        public void AddResult(bool res)
        {
            if (res) Result = true;
        }
    }
}
