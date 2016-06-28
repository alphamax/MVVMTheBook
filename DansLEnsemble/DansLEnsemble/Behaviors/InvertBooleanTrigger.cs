using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace DansLEnsemble.Behaviors
{
    public class InvertBooleanTrigger : TargetedTriggerAction<FrameworkElement>
    {
        #region LinkedProperty

        /// <summary>
        /// LinkedProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty LinkedPropertyProperty =
            DependencyProperty.Register("LinkedProperty", typeof(bool), typeof(InvertBooleanTrigger),
                new FrameworkPropertyMetadata((bool)false));

        /// <summary>
        /// Gets or sets the LinkedProperty property. This dependency property 
        /// indicates ....
        /// </summary>
        public bool LinkedProperty
        {
            get { return (bool)GetValue(LinkedPropertyProperty); }
            set { SetValue(LinkedPropertyProperty, value); }
        }

        #endregion        

        protected override void Invoke(object parameter)
        {
                LinkedProperty = !LinkedProperty;
        }
    }
}
