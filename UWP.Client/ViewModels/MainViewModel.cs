﻿using GalaSoft.MvvmLight;
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
            
            // TODO: wire this up to the name of another page and pass a parameter
            this.NavigateCommand = new RelayCommand(() => _navigationService.NavigateTo("SecondPage", null));

            this.HelloWorldText = "Hello world.";
        }
    }
}