using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Observable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public DispatcherTimer Timer { get; set; }
        public List<string> TimesInList { get; set; }
        public ObservableCollection<string> TimesInObs { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            TimesInList = new List<string>();
            TimesInObs = new ObservableCollection<string>();

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("TimesInList"));
                PropertyChanged(this, new PropertyChangedEventArgs("TimesInObs"));
            }


            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += (s, e) =>
            {
                TimesInList.Add(DateTime.Now.ToLongTimeString());
                TimesInObs.Add(DateTime.Now.ToLongTimeString());
            };
            Timer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
