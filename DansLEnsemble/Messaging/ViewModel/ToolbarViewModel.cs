using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MessagingTest.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingTest.ViewModel
{
    public class ToolbarViewModel : ViewModelBase
    {
        #region NewFileCommand
        private RelayCommand<object> _NewFileCommand;
        public RelayCommand<object> NewFileCommand
        {
            get
            {
                if (_NewFileCommand == null)
                    _NewFileCommand
                        = new RelayCommand<object>(
                            param => NewFile(param),
                            param => true);
                return _NewFileCommand;
            }
        }

        private void NewFile(object param)
        {
            MessengerInstance.Send(new StatusActionMessage(StatusAction.NewFile));
        }

        #endregion NewFileCommand

        #region CopyCommand
        private RelayCommand<object> _CopyCommand;
        public RelayCommand<object> CopyCommand
        {
            get
            {
                if (_CopyCommand == null)
                    _CopyCommand
                        = new RelayCommand<object>(
                            param => Copy(param),
                            param => CanCopy(param));
                return _CopyCommand;
            }
        }

        private bool CanCopy(object param)
        {
            return true;
        }

        private void Copy(object param)
        {
            if (CanCopy(param))
            {
                MessengerInstance.Send(new StatusActionMessage(StatusAction.Copy));
            }
        }

        #endregion CopyCommand

        #region CutCommand
        private RelayCommand<object> _CutCommand;
        public RelayCommand<object> CutCommand
        {
            get
            {
                if (_CutCommand == null)
                    _CutCommand
                        = new RelayCommand<object>(
                            param => Cut(param),
                            param => CanCut(param));
                return _CutCommand;
            }
        }

        private bool CanCut(object param)
        {
            return true;
        }

        private void Cut(object param)
        {
            if (CanCut(param))
            {
                MessengerInstance.Send(new StatusActionMessage(StatusAction.Cut));
            }
        }

        #endregion CutCommand

        #region PasteCommand
        private RelayCommand<object> _PasteCommand;
        public RelayCommand<object> PasteCommand
        {
            get
            {
                if (_PasteCommand == null)
                    _PasteCommand
                        = new RelayCommand<object>(
                            param => Paste(param),
                            param => CanPaste(param));
                return _PasteCommand;
            }
        }

        private bool CanPaste(object param)
        {
            return true;
        }

        private void Paste(object param)
        {
            if (CanPaste(param))
            {
                MessengerInstance.Send(new StatusActionMessage(StatusAction.Paste));
            }
        }

        #endregion PasteCommand
    }
}
