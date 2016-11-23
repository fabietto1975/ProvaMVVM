using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class MDIContainerViewModel : ViewModelBase
    {
        private ObservableCollection<MDIWindowViewModel> _windows = new ObservableCollection<MDIWindowViewModel>();

        public ObservableCollection<MDIWindowViewModel> Windows
        {
            set
            {
                Set(ref _windows, value);
            }
            get { return _windows; }
        }

        public MDIContainerViewModel()
        {
            MDIWindowViewModel w1 = new MDIWindowViewModel("w1");
            MDIWindowViewModel w2 = new MDIWindowViewModel("w2");
            _windows.Add(w1);
            _windows.Add(w2);

        }
    }
}
