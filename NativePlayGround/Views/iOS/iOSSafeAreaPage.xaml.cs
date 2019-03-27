using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSSafeAreaPage : ContentPage
    {
        public iOSSafeAreaPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            On<iOS>().SetUseSafeArea(false);
            (sender as Button).IsEnabled = false;
        }
    }
}
