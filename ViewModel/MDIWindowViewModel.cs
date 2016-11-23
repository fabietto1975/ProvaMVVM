using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class MDIWindowViewModel : ViewModelBase
    {
        private string _titolo;
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                Set(ref _titolo, value);
            }
        }
        public MDIWindowViewModel(string titolo)
        {
            _titolo = titolo;
        }
    }
}
