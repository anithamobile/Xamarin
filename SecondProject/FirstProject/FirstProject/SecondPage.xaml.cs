
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page_Navigation_Using_Xamarin_Forms
{

    [DesignTimeVisible(false)]
    public partial class SecondPage : ContentPage
    {



        SecondPageVM vm;

        public SecondPage()
        {
            InitializeComponent();

            vm = new SecondPageVM();
            this.BindingContext = vm;
        }
    }
}