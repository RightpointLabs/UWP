using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace UWP.Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string HelloWorldText { get; set; }

        public RelayCommand NavigateCommand { get; set; }

        public MainViewModel(NavigationService navigationService) : base(navigationService)
        {
            this.NavigateCommand = new RelayCommand(() => base.NavigationService.NavigateTo("SecondPage", "Custom parameter"));

            this.HelloWorldText = "Hello world.";
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            // load logic (note that "e" contains Parameter)

            base.OnNavigatedTo(e);
        }
    }
}
