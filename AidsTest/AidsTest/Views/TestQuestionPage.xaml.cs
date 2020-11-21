using AidsTest.Models;
using AidsTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AidsTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestQuestionPage : ContentPage, INotifyPropertyChanged
    {
        private QuestionViewModel _viewModel;
        Questionnaire Questionnaire;
        public Question CurrentQuestion { get; set; }
        private List<Question> Questions { get; set; }
        private List<Question> QuestionsWithAnswers { get; set; }
      //  GenderCounter genderCounter ;
        bool SS = false;
        private int j = 0;
        private int k = 0;
        public string PrintableSex { get; set; }


        public TestQuestionPage()
        {
            InitializeComponent();
            
            _viewModel = new QuestionViewModel();
            Questionnaire = new Questionnaire();
            Questions = Questionnaire.AllStartQuestions;
            QuestionsWithAnswers = new List<Question>();
         //   genderCounter = new GenderCounter();
            SS = GenderCounter.SexStarted;
            CurrentQuestion = Questions[0];
            Questions.RemoveAt(0);
             printSex(SS);
            BindingContext = this;
        }
        //private void StartTest(object sender, EventArgs e)
        //{
        //   LoadQuestionAndSex(CurrentQuestion);
        //}
        private string printSex(bool b)
        {
             OnAppearing();
            sexPic.Source = b ? "sex_w.png" : "sex_m.png";
         //   sexLbl.Text = "";
            //   return sexLbl.Text = b ? "мужчины" : "женщины";
          
            PrintableSex = sexLbl.Text = b ? "мужчины" : "женщины";
            OnAppearing();
            //   PrintableSex =  b ? "мужчины" : "женщины";
            return PrintableSex;
        }

        private async void LoadQuestionAndSex(Question qu)
        { 
            j++;
            //questionLbl.ScaleXTo(1);
            //answerLc.ScaleTo(1);
            CurrentQuestion = qu;
            foreach (var v in CurrentQuestion.Answers)
                v.Color = Color.Transparent;
            if (j%2 == 0 || j == 0)  printSex (SS);
                else  printSex(!SS);
            
            await Task.WhenAll(mainsl.FadeTo(1, 500), mainsl.FadeTo(0, 500));
            questionLbl.Text = CurrentQuestion.QuestionText;
            answerLc.ItemsSource = CurrentQuestion.Answers;
            await Task.WhenAll(mainsl.FadeTo(0, 500), mainsl.FadeTo(1, 500));

           
            //TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            //tapGesture.Tapped += OnSlViewTapped;
            ////tapGesture.CommandParameter = args;
            ////tapGesture.Command = new Command(MoveToNextQuestion);
            //sl.GestureRecognizers.Add(tapGesture);
            
          }

        async protected override void OnAppearing()
        {
            base.OnAppearing();
            sexPic.AnchorX = 0;
            sexLbl.AnchorX = 0;
            sexPic.RotationY = 180;
            sexLbl.RotationY = 180;
            await sexPic.RotateYTo(0, 500, Easing.CubicOut);
            await sexLbl.RotateYTo(0, 500, Easing.CubicOut);
            sexPic.AnchorX = 0.5;
            sexLbl.AnchorX = 0.5;
        }

    private void ShowResults()
        {
            
            questForSl.IsVisible = false;
            nextQBtn.IsVisible = false;
            mainsl.Children.Clear();
            ResultsCount texts = new ResultsCount();
            ScoreCounter scoreCounter = new ScoreCounter(QuestionsWithAnswers);

            mainsl.Children.Add(new Label()
            {
                Text = texts.GeneralText
            });
          //  int mult = _viewModel.CheckCoincidences(QuestionsWithAnswers);

            mainsl.Children.Add(new Label() { Text = "Результаты: " });
           
            mainsl.Children.Add(new Label()
            {
              //  Text = texts.ChooseResultString(scoreCounter.FirstPersonScore + mult * 2, scoreCounter.SecondPersonScore + mult * 2)
                Text = texts.ChooseResultString(scoreCounter.FirstPersonScore , scoreCounter.SecondPersonScore)
            });

            if(k < 2) 
            { 
                Button returnBtn = new Button();
                returnBtn.Text = "Повторить тест";
                returnBtn.Margin = 30;
                returnBtn.HorizontalOptions = LayoutOptions.Center;
                returnBtn.Clicked += TestQuestionPage_Clicked;
                mainsl.Children.Add(returnBtn);
            }
            k++;
        }

        private async void TestQuestionPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("startPage");
        }

        private void nextBtn_Clicked(object sender, EventArgs e)
        {
            var s = (Button)sender;
            //s.RotateTo(360, 1000);
          //  OnAppearing();

            if (CurrentQuestion.Answers.Where(c => c.Color.Name == "ffb22222").Any())
            {
                QuestionsWithAnswers.Add(CurrentQuestion);

               
                if (Questions.Count > 1)
                {
                    LoadQuestionAndSex(Questions[0]);
                    Questions.RemoveAt(0);
                }
              else
                    ShowResults();
            }
             else OutputAlertString();
       }
        private void OutputAlertString(string s = "Укажите ответ") => AlertLbl.Text = s;
        
        private void answerLc_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AlertLbl.Text = "";
             ListView listView = sender as ListView;
             Answer ans = (Answer)e.SelectedItem;
       
            if(ans != null)
                CurrentQuestion = _viewModel.ChangeColor(CurrentQuestion, ans);
            listView.SelectedItem = null;
         }

    }
}