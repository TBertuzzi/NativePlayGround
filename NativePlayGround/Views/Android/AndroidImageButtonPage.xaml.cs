using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;


namespace NativePlayGround.Views.Android
{
    public partial class AndroidImageButtonPage : ContentPage
    {
        public AndroidImageButtonPage()
        {
            InitializeComponent();
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            var imageButton = sender as Xamarin.Forms.ImageButton;
            imageButton.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsShadowEnabled(!imageButton.On<Xamarin.Forms.PlatformConfiguration.Android>().GetIsShadowEnabled());
        }
    }
}
