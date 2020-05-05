using FirstProject.Model;
using FirstProject.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Page_Navigation_Using_Xamarin_Forms
{
    public class SecondPageVM : INotifyPropertyChanged
    {
        public SecondPageVM()
        {
            TodoModel model = RestService.model;

            userId = model.userId.ToString();
            id = model.id.ToString();
            title = model.title;
            completed = model.completed.ToString();


        }

        public event PropertyChangedEventHandler PropertyChanged;

        string _userId;
        public string userId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                OnPropertyChanged("userId");
            }
        }

        string _id;
        public string id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("id");
            }
        }

        string _title;
        public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("title");
            }
        }

        string _completed;
        public string completed
        {
            get { return _completed; }
            set
            {
                _completed = value;
                OnPropertyChanged("completed");
            }
        }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
