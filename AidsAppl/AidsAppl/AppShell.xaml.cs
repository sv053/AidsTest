using System;
using System.Collections.Generic;
using AidsAppl.ViewModels;
using AidsAppl.Views;
using Xamarin.Forms;

namespace AidsAppl
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
