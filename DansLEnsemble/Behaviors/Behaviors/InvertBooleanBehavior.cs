using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace DansLEnsemble.Behaviors
{
    public class InvertBooleanBehavior : Behavior<Button>
    {
        #region LinkedProperty

        /// <summary>
        /// LinkedProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty LinkedPropertyProperty =
            DependencyProperty.Register("LinkedProperty", typeof(bool), typeof(InvertBooleanBehavior),
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

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Click += AssociatedObject_Click;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.Click -= AssociatedObject_Click;
            base.OnDetaching();
        }

        void AssociatedObject_Click(object sender, RoutedEventArgs e)
        {
            LinkedProperty = !LinkedProperty;
        }

    }
}
