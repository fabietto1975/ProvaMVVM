using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MVVM.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<ILanguageService, LanguageService>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MDIContainerViewModel>();
        }

        public MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public MDIContainerViewModel MainContainer
        {
            get { return ServiceLocator.Current.GetInstance<MDIContainerViewModel>(); }

        }
    }
}
