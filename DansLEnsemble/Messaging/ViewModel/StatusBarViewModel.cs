using GalaSoft.MvvmLight;
using MessagingTest.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingTest.ViewModel
{
    public class StatusBarViewModel : ViewModelBase
    {
        public StatusBarViewModel()
        {
            MessengerInstance.Register<StatusActionMessage>(this,
                (message) =>
                {
                    switch (message.Status)
                    {
                        case StatusAction.NewFile:
                            StatusContent = "Nouveau fichier créé";
                            break;
                        case StatusAction.Copy:
                            StatusContent = "Fichier copié";
                            break;
                        case StatusAction.Cut:
                            StatusContent = "Fichier coupé";
                            break;
                        case StatusAction.Paste:
                            StatusContent = "Fichier collé";
                            break;
                        default:
                            break;
                    }
                });
        }

        #region StatusContent
        private string _StatusContent = string.Empty;

        /// <summary>
        /// Sets and gets the StatusContent property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string StatusContent
        {
            get
            {
                return _StatusContent;
            }

            set
            {
                if (_StatusContent == value)
                {
                    return;
                }

                _StatusContent = value;
                RaisePropertyChanged("StatusContent");
            }
        }
        #endregion
    }
}
