using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Templating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Plane> allPlanes { get; set; }

        public MainWindow()
        {
            allPlanes = new ObservableCollection<Plane>();
            // Required to initialize variables
            InitializeComponent();
            this.DataContext = this;

            allPlanes.Add(new Plane("Tango1", 20, 200));
            allPlanes.Add(new Plane("Bravo2", 100, 200));
            allPlanes.Add(new Plane("Alpha0", 25, 50));
            allPlanes.Add(new Plane("AirForceOne", 125, 100));
        }
    }
}
