using AidsTest.Services;
using AidsTest.Views;
using Xamarin.Forms;


namespace AidsTest
{

    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
               MainPage = new AppShell();
         //   MainPage = new AboutPage();
            //     MainPage = new StartPage();
            //  MainPage = new TestQuestionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
