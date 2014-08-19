using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;

namespace MyModelNotify
{
    public class Foo : INotifyPropertyChanged
    {
        private string _name;
        private int _counter;
        private DataUpdater _dataUpdater;

        public string Name {
            get { return this._name; }
            private set {
                this._name = value;
                RaisePropertyChanged("Name");
            }
        }

        public int Counter
        {
            get { return this._counter; }
            set { 
                this._counter = value;
                RaisePropertyChanged("Counter");
            }
        }

        public Foo(string name, int initialValue)
        {
            this._name = name;
            this._counter = initialValue;
            this._dataUpdater = new DataUpdater(this);
            this._dataUpdater.Run();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            // Use a copy to prevent thread issues
            //
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
