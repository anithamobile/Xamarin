using Page_Navigation_Using_Xamarin_Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new Page_Navigation_Using_Xamarin_Forms.MainPage());
            
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
