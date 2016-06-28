using GalaSoft.MvvmLight;
using ModelFirst.Helper;
using System;
using System.Linq;
using System.Collections.Generic;
using BusinessIntelligence.MessageSample;

namespace BusinessIntelligence.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Notes = new List<Note>();
            for (int i = 0; i < 100; i++)
            {
                Notes.Add(GenerateurNote.GenererNote());
            }
            InitialisationBI();
        }

        public List<Note> Notes { get; set; }

        private void InitialisationBI()
        {
            ComptageNote = Notes
                            .GroupBy(c => c.Valeur)
                            .Select(c => new KeyValuePair<int, int>(c.Key, c.Count()))
                            .ToList();
            Moyenne = (float)Notes.Sum(c => c.Valeur) / (float)Notes.Count;
            AuDessusMoyenne = Notes
                            .Where(c => c.Valeur > Moyenne)
                            .GroupBy(c => c.Academie)
                            .Select(c => new KeyValuePair<string, int>(c.Key, c.Count()))
                            .ToList();
        }

        #region ComptageNote
        private List<KeyValuePair<int, int>> _ComptageNote = new List<KeyValuePair<int, int>>();

        public List<KeyValuePair<int, int>> ComptageNote
        {
            get
            {
                return _ComptageNote;
            }

            set
            {
                if (_ComptageNote == value)
                {
                    return;
                }

                _ComptageNote = value;
                RaisePropertyChanged("ComptageNote");
            }
        }
        #endregion

        #region Moyenne
        private float _Moyenne = 0;

        public float Moyenne
        {
            get
            {
                return _Moyenne;
            }

            set
            {
                if (_Moyenne == value)
                {
                    return;
                }

                _Moyenne = value;
                RaisePropertyChanged("Moyenne");
            }
        }
        #endregion

        #region AuDessusMoyenne
        private List<KeyValuePair<string, int>> _AuDessusMoyenne = new List<KeyValuePair<string,int>>();

        public List<KeyValuePair<string, int>> AuDessusMoyenne
        {
            get
            {
                return _AuDessusMoyenne;
            }

            set
            {
                if (_AuDessusMoyenne == value)
                {
                    return;
                }

                _AuDessusMoyenne = value;
                RaisePropertyChanged("AuDessusMoyenne");
            }
        }
        #endregion
    }
}