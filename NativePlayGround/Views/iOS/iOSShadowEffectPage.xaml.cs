using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSShadowEffectPage : ContentPage
    {
        public iOSShadowEffectPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _boxView.On<iOS>().SetIsShadowEnabled(!_boxView.On<iOS>().GetIsShadowEnabled());
        }
    }
}
