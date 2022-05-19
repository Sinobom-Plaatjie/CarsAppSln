using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var pageTheme = new NavigationPage(new MainPage());
            pageTheme.BarBackgroundColor = Color.LightSlateGray;
            MainPage = pageTheme;   
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
