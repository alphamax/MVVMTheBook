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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GlassPane
{
    [ContentProperty("Children")]
    public partial class WaitControl : UserControl
    {
        public WaitControl()
        {
            InitializeComponent();
            Children = GridConteneur.Children;
        }

        #region Children

        public static readonly DependencyProperty ChildrenProperty =
            DependencyProperty.Register("Children", typeof(UIElementCollection), typeof(WaitControl),
                new FrameworkPropertyMetadata((UIElementCollection)null));

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty); }
            set { SetValue(ChildrenProperty, value); }
        }

        #endregion

        #region IsLoading

        public static readonly DependencyProperty IsLoadingProperty =
            DependencyProperty.Register("IsLoading", typeof(bool), typeof(WaitControl),
                new FrameworkPropertyMetadata((bool)false,
                    new PropertyChangedCallback(OnIsLoadingChanged)));

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }

        private static void OnIsLoadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WaitControl target = (WaitControl)d;
            bool oldIsLoading = (bool)e.OldValue;
            bool newIsLoading = target.IsLoading;
            target.OnIsLoadingChanged(oldIsLoading, newIsLoading);
        }

        protected virtual void OnIsLoadingChanged(bool oldIsLoading, bool newIsLoading)
        {
            if (newIsLoading)
            {
                VisualStateManager.GoToState(this, "WaitVisualState", true);
            }
            else
            {
                VisualStateManager.GoToState(this, "NoWaitVisualState", true);
            }
        }

        #endregion
    }
}
