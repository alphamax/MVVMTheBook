using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace DansLEnsemble.Behaviors
{
    public class IncrementTrigger : TargetedTriggerAction<FrameworkElement>
    {
        #region LinkedProperty

        /// <summary>
        /// LinkedProperty Dependency Property
        /// </summary>
        public static readonly DependencyProperty LinkedPropertyProperty =
            DependencyProperty.Register("LinkedProperty", typeof(int), typeof(IncrementTrigger),
                new FrameworkPropertyMetadata((int)0));

        /// <summary>
        /// Gets or sets the LinkedProperty property. This dependency property 
        /// indicates ....
        /// </summary>
        public int LinkedProperty
        {
            get { return (int)GetValue(LinkedPropertyProperty); }
            set { SetValue(LinkedPropertyProperty, value); }
        }

        #endregion 
       
        #region Delta

        /// <summary>
        /// Delta Dependency Property
        /// </summary>
        public static readonly DependencyProperty DeltaProperty =
            DependencyProperty.Register("Delta", typeof(int), typeof(IncrementTrigger),
                new FrameworkPropertyMetadata((int)0));

        /// <summary>
        /// Gets or sets the Delta property. This dependency property 
        /// indicates ....
        /// </summary>
        public int Delta
        {
            get { return (int)GetValue(DeltaProperty); }
            set { SetValue(DeltaProperty, value); }
        }

        #endregion

        protected override void Invoke(object parameter)
        {
            LinkedProperty += Delta;
        }
    }
}
