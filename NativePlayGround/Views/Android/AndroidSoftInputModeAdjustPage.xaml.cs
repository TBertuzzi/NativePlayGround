using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidSoftInputModeAdjustPage : ContentPage
    {
        public AndroidSoftInputModeAdjustPage()
        {
            InitializeComponent();
        }

        void OnPanButtonClicked(object sender, EventArgs e)
        {
            App.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
        }

        void OnResizeButtonClicked(object sender, EventArgs e)
        {
            App.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }
    }
}
