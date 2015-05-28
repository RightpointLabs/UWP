﻿using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace UWP.Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public string HelloWorldText { get; set; }

        public RelayCommand NavigateCommand { get; set; }

        public MainViewModel(NavigationService navigationService)
        {
            this._navigationService = navigationService;
            
            this.NavigateCommand = new RelayCommand(() => _navigationService.NavigateTo("SecondPage", "Custom parameter"));

            this.HelloWorldText = "Hello world.";
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            // load logic (note that "e" contains Parameter)

            base.OnNavigatedTo(e);
        }
    }
}
