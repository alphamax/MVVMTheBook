using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstModel.MVVM
{
    class AddTemperatureCommand : ICommand
    {
        private Action OnAddTemperature;
        
        public AddTemperatureCommand(Action onAddTemperature)
        {
            OnAddTemperature = onAddTemperature;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (OnAddTemperature != null)
            {
                OnAddTemperature();
            }
        }
    }
}
