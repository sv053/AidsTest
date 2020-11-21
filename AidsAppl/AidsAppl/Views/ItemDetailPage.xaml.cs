using System.ComponentModel;
using Xamarin.Forms;
using AidsAppl.ViewModels;

namespace AidsAppl.Views
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