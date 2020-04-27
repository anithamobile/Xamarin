using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Xamarin.Forms;

namespace FirstProject.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public MainPageVM()
        {
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        string _labelText;
        public string labelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                OnPropertyChanged("labelText");
            }
        }

        string _entryText;
        public string entryText
        {
            get { return _entryText; }
            set
            {
                _entryText = value;
                OnPropertyChanged("entryText");
            }
        }

        public void onButtonClicked()
        {
            labelText = entryText;
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}