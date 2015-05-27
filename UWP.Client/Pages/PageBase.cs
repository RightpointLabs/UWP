using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;

namespace UWP.Client.Pages
{
    public class PageBase : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string fullName = $"{e.SourcePageType.Namespace}.ViewModels.{e.SourcePageType.Name.Replace("Page", "ViewModel")}";
            Type viewModelType = Type.GetType(fullName);
            ViewModelBase viewModel = ServiceLocator.Current.GetInstance(viewModelType) as ViewModelBase;
            this.DataContext = viewModel;

            base.OnNavigatedTo(e);
        }
    }
}
