using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample1
{
    class MainViewModel : INotifyPropertyChanged
    {
        private DateTime _時刻 = DateTime.Now;

        public DateTime 時刻
        {
            get => _時刻;
            set
            {
                _時刻 = value;
                OnPropertyChanged(nameof(時刻));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
