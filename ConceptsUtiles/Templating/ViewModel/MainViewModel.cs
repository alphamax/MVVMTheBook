using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace Templating.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            Vehicules.Add(new VeloViewModel() { Nom = "Velo II" });
            Vehicules.Add(new VoitureViewModel() { Nom = "Voiture  I", Immatriculation = "AA 123 AA" });
            Vehicules.Add(new VeloViewModel() { Nom = "Velo III" });
            Vehicules.Add(new VeloViewModel() { Nom = "Velo V" });
        }

        #region Vehicules
        private ObservableCollection<VehiculeViewModel> _Vehicules = new ObservableCollection<VehiculeViewModel>();

        public ObservableCollection<VehiculeViewModel> Vehicules
        {
            get
            {
                return _Vehicules;
            }

            set
            {
                if (_Vehicules == value)
                {
                    return;
                }

                _Vehicules = value;
                RaisePropertyChanged("Vehicules");
            }
        }
        #endregion
    }
}