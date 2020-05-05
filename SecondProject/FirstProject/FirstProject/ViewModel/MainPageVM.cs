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

        public async Task<TodoModel> onButtonClickedAsync()
        {
            //labelText = entryText;

            TodoModel model = await GetTodo();
            return model;
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task<TodoModel> GetTodo()
        {
            try
            {
                //TodoModel model = new TodoModel();
                RestService service = new RestService();
                TodoModel model = await service.GetRequest<TodoModel>("https://jsonplaceholder.typicode.com/todos/1");

                RestService.model = model;
                return model;
            }catch(Exception e)
            {

            }
            return null;
        }


    }
}