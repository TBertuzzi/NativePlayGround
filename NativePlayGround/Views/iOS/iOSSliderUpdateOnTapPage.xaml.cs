using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSSliderUpdateOnTapPage : ContentPage
    {
        public iOSSliderUpdateOnTapPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _slider.On<iOS>().SetUpdateOnTap(!_slider.On<iOS>().GetUpdateOnTap());
        }
    }
}
