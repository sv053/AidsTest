using Xamarin.Forms;

namespace AidsTest.Views
{
    public partial class AboutPage : ContentPage
    { 
        public Command LoadTestCommand { get; }
        public AboutPage()
        {
            
            InitializeComponent();
            //    BindingContext = this;
            LoadTestCommand = new Command(OnStartBtnClicked);
        }

        private void goSimpleBtn_Clicked(object sender, System.EventArgs e)
        {
          //  async () => await Shell.Current.GoToAsync($"{nameof(TestQuestionPage)}");
           
        }

        private async void OnStartBtnClicked(object obj)
        {
            //  await Shell.Current.GoToAsync($"{nameof(TestQuestionPage)}");
            await Shell.Current.GoToAsync($"{nameof(StartPage)}");
        }
    }
}