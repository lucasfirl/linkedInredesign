using LinkedIn_Redesign.Services;
using LinkedIn_Redesign.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LinkedIn_Redesign
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
