using AidsTest.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AidsTest.Models;

namespace AidsTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public string Gender { get; }
        public Command RoutToPage { get; set; }
        public StartPage()
        {
            InitializeComponent();
            RoutToPage = new Command(OnBtnClicked);
            this.BindingContext = this;
            Gender = GenderCounter.SexStarted? " Первым отвечает мужчина" : "Первой отвечает женщина";
            sexLbl.Text = Gender;
        }

        private async void OnBtnClicked(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(TestQuestionPage)}");
        }
       
    }
}