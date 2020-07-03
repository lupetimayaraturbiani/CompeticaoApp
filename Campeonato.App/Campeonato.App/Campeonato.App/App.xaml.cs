using System;
using Campeonato.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Splash();
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
