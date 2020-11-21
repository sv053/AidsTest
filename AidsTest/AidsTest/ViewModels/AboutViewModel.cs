using AidsTest.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AidsTest.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "";
            //   OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
            //   OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
         //   OpenTestPageCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(TestQuestionPage)}"));
            OpenTestPageCommand = new Command(async () => await Shell.Current.GoToAsync("startPage"));
        }

        public ICommand OpenTestPageCommand { get; }
    }
}