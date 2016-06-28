using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace DansLEnsemble.Behaviors
{
    class DroitBehavior : Behavior<FrameworkElement>
    {
        #region Droits

        /// <summary>
        /// Droits Dependency Property
        /// </summary>
        public static readonly DependencyProperty DroitsProperty =
            DependencyProperty.Register("Droits", typeof(List<string>), typeof(DroitBehavior),
                new FrameworkPropertyMetadata((List<string>)null,
                    FrameworkPropertyMetadataOptions.None,
                    new PropertyChangedCallback(OnDroitsChanged)));

        /// <summary>
        /// Gets or sets the Droits property. This dependency property 
        /// indicates ....
        /// </summary>
        public List<string> Droits
        {
            get { return (List<string>)GetValue(DroitsProperty); }
            set { SetValue(DroitsProperty, value); }
        }

        /// <summary>
        /// Handles changes to the Droits property.
        /// </summary>
        private static void OnDroitsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DroitBehavior target = (DroitBehavior)d;
            List<string> oldDroits = (List<string>)e.OldValue;
            List<string> newDroits = target.Droits;
            target.OnDroitsChanged(oldDroits, newDroits);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the Droits property.
        /// </summary>
        protected virtual void OnDroitsChanged(List<string> oldDroits, List<string> newDroits)
        {
            MiseAJourDroit()
        }

        #endregion

        #region DroitNecessaire

        /// <summary>
        /// DroitNecessaire Dependency Property
        /// </summary>
        public static readonly DependencyProperty DroitNecessaireProperty =
            DependencyProperty.Register("DroitNecessaire", typeof(string), typeof(DroitBehavior),
                new FrameworkPropertyMetadata((string)string.Empty,
                    new PropertyChangedCallback(OnDroitNecessaireChanged)));

        /// <summary>
        /// Gets or sets the DroitNecessaire property. This dependency property 
        /// indicates ....
        /// </summary>
        public string DroitNecessaire
        {
            get { return (string)GetValue(DroitNecessaireProperty); }
            set { SetValue(DroitNecessaireProperty, value); }
        }

        /// <summary>
        /// Handles changes to the DroitNecessaire property.
        /// </summary>
        private static void OnDroitNecessaireChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DroitBehavior target = (DroitBehavior)d;
            string oldDroitNecessaire = (string)e.OldValue;
            string newDroitNecessaire = target.DroitNecessaire;
            target.OnDroitNecessaireChanged(oldDroitNecessaire, newDroitNecessaire);
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the DroitNecessaire property.
        /// </summary>
        protected virtual void OnDroitNecessaireChanged(string oldDroitNecessaire, string newDroitNecessaire)
        {
            MiseAJourDroit();
        }

        #endregion



        

        private void MiseAJourDroit()
        {
            if (Droits != null && !string.IsNullOrWhiteSpace(DroitNecessaire))
            {
                if (Droits.Contains(DroitNecessaire))
                {
                    AssociatedObject.Visibility = Visibility.Visible;
                }
                else
                {
                    AssociatedObject.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                AssociatedObject.Visibility = Visibility.Collapsed;
            }
        }

        
    }
}
