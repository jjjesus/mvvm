using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MyModelNotify
{
    public class FooViewModel : INotifyPropertyChanged
    {
        private Foo _foo { get; set; }

        public string Name {
            get
            {
                return _foo.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public int Counter
        {
            get
            {
                return _foo.Counter;
            }
            set
            {
                this.Counter = value;
            }
        }

        public FooViewModel(Foo aFoo)
        {
            this._foo = aFoo;
            this._foo.PropertyChanged += this.Foo_PropertyChanged;
        }

        private void Foo_PropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Counter")
            {
                RaisePropertyChanged("Counter");
            }
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
