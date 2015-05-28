using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace UWP.Client.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public string HelloWorldText { get; set; }

        public RelayCommand NavigateCommand { get; set; }

        public SecondViewModel(NavigationService navigationService)
        {
            this._navigationService = navigationService;
            
            this.NavigateCommand = new RelayCommand(() => _navigationService.NavigateTo("MainPage", null));

            this.HelloWorldText = "This is the Second Page.";
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            // load logic (note that "e" contains Parameter)

            base.OnNavigatedTo(e);
        }
    }
}
