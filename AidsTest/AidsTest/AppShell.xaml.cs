using AidsTest.Views;
using System;
using Xamarin.Forms;

namespace AidsTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(TestQuestionPage), typeof(TestQuestionPage));
            Routing.RegisterRoute("startPage", typeof(StartPage));
            Routing.RegisterRoute("startPage1", typeof(StartPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
         //   await Shell.Current.GoToAsync("//TestQuestionPage");
            await Shell.Current.GoToAsync("//AboutPage");
            //     await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
