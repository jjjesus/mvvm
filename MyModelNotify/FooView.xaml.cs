using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyModelNotify
{
    /// <summary>
    /// Interaction logic for FooView.xaml
    /// </summary>
    public partial class FooView : UserControl
    {
        public FooView()
        {
            ViewModel = new FooViewModel( new Foo("FOO", 21) );
            DataContext = ViewModel;
            InitializeComponent();
        }
        public FooViewModel ViewModel { get; set; }
    }
}
