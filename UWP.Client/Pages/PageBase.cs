using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.ServiceLocation;

namespace UWP.Client.Pages
{
    public class PageBase : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string fullName = $"{e.SourcePageType.Namespace}.ViewModels.{e.SourcePageType.Name.Replace("Page", "ViewModel")}";
            Type viewModelType = Type.GetType(fullName);
            this.DataContext = ServiceLocator.Current.GetInstance(viewModelType);

            base.OnNavigatedTo(e);
        }
    }
}
