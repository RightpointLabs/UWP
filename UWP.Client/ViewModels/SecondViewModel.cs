using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace UWP.Client.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        public string HelloWorldText { get; set; }

        public RelayCommand NavigateCommand { get; set; }

        public SecondViewModel(NavigationService navigationService) : base(navigationService)
        {
            this.NavigateCommand = new RelayCommand(() => base.NavigationService.NavigateTo("MainPage", "Custom parameter 2"));

            this.HelloWorldText = "This is the Second Page.";
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            // load logic (note that "e" contains Parameter)

            base.OnNavigatedTo(e);
        }
    }
}
