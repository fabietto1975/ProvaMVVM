using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM.Model;
using MVVM.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private List<Language> _listaLinguaggi;

        private Language _linguaGenerazione;
        public Language LinguaGenerazione
        {
            get { return _linguaGenerazione; }
            set { Set (ref _linguaGenerazione , value); }
        }

        public List<Language> ListaLinguaggi 
        {
            get { return _listaLinguaggi; }
        }

        private readonly ILanguageService _languageService;

        public MainViewModel(ILanguageService languageService)
        {
            _languageService = languageService;
            _listaLinguaggi = _languageService.LeggiListaLinguaggi();
        }
    }
}
