﻿using Prism.Navigation;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class StartTutorialPageViewModel : ViewModelBase
    {
        public StartTutorialPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public Command OnClickStart => new Command(async () =>
        {
            await NavigationService.NavigateAsync("DescriptionPage");
        });

    }
}
