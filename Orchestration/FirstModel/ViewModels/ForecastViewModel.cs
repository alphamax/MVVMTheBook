using FirstModel.Models;
using FirstModel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FirstModel.ViewModels
{
    class ForecastViewModel : INotifyPropertyChanged
    {
        public ForecastViewModel()
        {
            Temperatures = new ObservableCollection<Temperature>(DeserializeTemperatures());
            AddTempCommand = new AddTemperatureCommand(AddTemperatureExecutionMethod);
        }

        #region Temperatures
        private ObservableCollection<Temperature> _Temperatures = new ObservableCollection<Temperature>();

        /// <summary>
        /// Sets and gets the Temperatures property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<Temperature> Temperatures
        {
            get
            {
                return _Temperatures;
            }

            set
            {
                if (_Temperatures == value)
                {
                    return;
                }

                _Temperatures = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Temperatures"));
                }
            }
        }
        #endregion

        public AddTemperatureCommand AddTempCommand { get; set; }

        private void AddTemperatureExecutionMethod()
        {
            Temperatures.Add(new Temperature() 
            { 
                Valeur = new Random(DateTime.Now.Millisecond).NextDouble() * 10d + 20d, 
                DateDePrise = DateTime.Now.Date 
            });
            SerializeTemperatures();
        }

        /// <summary>
        /// Sauvegarde du modèle
        /// </summary>
        public void SerializeTemperatures()
        {
            var serialiseur = new XmlSerializer(typeof(List<Temperature>));
            using (var writer = XmlWriter.Create("Temperatures.xml"))
            {
                serialiseur.Serialize(writer, Temperatures.ToList());
            }
        }

        /// <summary>
        /// Chargement du modèle
        /// </summary>
        /// <returns></returns>
        public List<Temperature> DeserializeTemperatures()
        {
            var serialiseur = new XmlSerializer(typeof(List<Temperature>));
            var resultat = new List<Temperature>();
            if (File.Exists("Temperatures.xml"))
            {
                using (var reader = XmlReader.Create("Temperatures.xml"))
                {
                    return (List<Temperature>)serialiseur.Deserialize(reader);
                }
            }
            return resultat;
        }

        /// <summary>
        /// Implémentation interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
