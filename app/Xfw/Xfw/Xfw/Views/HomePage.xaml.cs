using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xfw.Models;
using Xfw.ViewModels;

namespace Xfw.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel ViewModel;

        public HomePage()
        {
            InitializeComponent();

            ViewModel = new HomeViewModel();
            BindingContext = ViewModel;
        }

        protected override async void OnAppearing()
        {
            await ViewModel.Initialize();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var movie = e.Item as Movie;

            await Navigation.PushAsync(new DetailPage(movie));
        }
    }
}