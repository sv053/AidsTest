using System.ComponentModel;
using Xamarin.Forms;
using AidsApp.ViewModels;

namespace AidsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}