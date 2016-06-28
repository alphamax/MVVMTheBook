using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace DansLEnsemble.Behaviors
{
    public class InvertVisibilityTrigger : TargetedTriggerAction<FrameworkElement>
    {
        #region LinkedProperty

        /// <summary>
        /// LinkedProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty LinkedPropertyProperty =
            DependencyProperty.Register("LinkedProperty", typeof(Visibility), typeof(InvertVisibilityTrigger),
                new FrameworkPropertyMetadata((Visibility)Visibility.Visible));

        /// <summary>
        /// Gets or sets the LinkedProperty property. This dependency property 
        /// indicates ....
        /// </summary>
        public Visibility LinkedProperty
        {
            get { return (Visibility)GetValue(LinkedPropertyProperty); }
            set { SetValue(LinkedPropertyProperty, value); }
        }

        #endregion        

        protected override void Invoke(object parameter)
        {
            if (LinkedProperty == Visibility.Visible)
            {
                LinkedProperty = Visibility.Collapsed;
            }
            else
            {
                LinkedProperty = Visibility.Visible;
            }
        }
    }
}
