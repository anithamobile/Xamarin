using FirstProject.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
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

            //label.Text = entry.Text;

            mainVM.onButtonClicked();
        }
    }
}
