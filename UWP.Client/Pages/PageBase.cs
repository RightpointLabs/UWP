
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.ServiceLocation;
using UWP.Client.ViewModels;

namespace UWP.Client.Pages
{
    public class PageBase : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string fullName = $"{e.SourcePageType.Namespace}.ViewModels.{e.SourcePageType.Name.Replace("Page", "ViewModel")}";
            Type viewModelType = Type.GetType(fullName);

            ViewModelBase viewModel = (ViewModelBase)ServiceLocator.Current.GetInstance(viewModelType);
            viewModel.OnNavigatedTo(e);

            this.DataContext = viewModel;

            base.OnNavigatedTo(e);
        }
    }
}
