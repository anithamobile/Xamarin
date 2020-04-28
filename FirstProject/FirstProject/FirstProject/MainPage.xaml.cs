using FirstProject;
using FirstProject.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Page_Navigation_Using_Xamarin_Forms
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainPageVM mainVM;
        public MainPage()
        {
            InitializeComponent();
            //mainVM = new MainPageVM();
            //this.BindingContext = mainVM;
        }


        async void OnButtonClicked(object sender, EventArgs args)
        {

            //label.Text = entry.Text;

            //mainVM.onButtonClicked();
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
