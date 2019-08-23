using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xfw.Views;

namespace Xfw
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var homePage = new HomePage();
            MainPage = new NavigationPage(homePage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
