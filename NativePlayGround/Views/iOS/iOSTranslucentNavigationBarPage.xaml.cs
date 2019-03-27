using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using System.Windows.Input;

namespace NativePlayGround
{
    public partial class iOSTranslucentNavigationBarPage : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public iOSTranslucentNavigationBarPage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnTranslucentNavigationBarButtonClicked(object sender, EventArgs e)
        {
            (Xamarin.Forms.Application.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(!(Xamarin.Forms.Application.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
