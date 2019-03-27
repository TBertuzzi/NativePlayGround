using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace NativePlayGround.Views
{
    public partial class iOSBlurEffectPage : ContentPage
    {
        public iOSBlurEffectPage()
        {
            InitializeComponent();
        }

        void OnNoBlurButtonClicked(object sender, EventArgs e)
        {
            boxView.On<iOS>().UseBlurEffect(BlurEffectStyle.None);
        }

        void OnExtraLightBlurButtonClicked(object sender, EventArgs e)
        {
            boxView.On<iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);
        }

        void OnLightBlurButtonClicked(object sender, EventArgs e)
        {
            boxView.On<iOS>().UseBlurEffect(BlurEffectStyle.Light);
        }

        void OnDarkBlurButtonClicked(object sender, EventArgs e)
        {
            boxView.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);
        }
    }
}
