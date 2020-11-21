using AidsTest.Models;
using AidsTest.ViewModels;
using Xamarin.Forms;

namespace AidsTest.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}