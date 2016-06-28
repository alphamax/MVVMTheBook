using FirstService.UI.WebServiceReference;
using System;
using System.Collections.Generic;
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

namespace FirstService.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           

        }

        public IEnumerable<Eleve> FindEleve()
        {
            WebServiceClient client = new WebServiceClient();
            return client.GetEtudiants();
        }

        public async void FindEleveAsync()
        {
            WebServiceClient client = new WebServiceClient();
            IEnumerable<Eleve> result =  await client.GetEtudiantsAsync();
            //Affectation du résultat
        }


    }
}
