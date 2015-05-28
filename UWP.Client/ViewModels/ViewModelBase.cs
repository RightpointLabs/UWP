using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace UWP.Client.ViewModels
{
    public class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase
    {
        protected readonly INavigationService NavigationService;

        public RelayCommand GoBackCommand { get; set; }

        protected ViewModelBase(NavigationService navigationService)
        {
            this.NavigationService = navigationService;

            this.GoBackCommand = new RelayCommand(() => this.NavigationService.GoBack());
        }

        public virtual void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
