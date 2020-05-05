using FirstProject;
using FirstProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            mainVM = new MainPageVM();
            this.BindingContext = mainVM;
        }


        async void OnButtonClicked(object sender, EventArgs args)
        {

            try
            {
                mainVM = new MainPageVM();
                //label.Text = entry.Text;

                TodoModel model = await mainVM.onButtonClickedAsync();
                await Navigation.PushAsync(new SecondPage());

                Debug.WriteLine("GOPI");
            }
           catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }


        }
    }
}
