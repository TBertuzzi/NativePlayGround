using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidElevationPage : ContentPage
    {
        public AndroidElevationPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            outputLabel.Text = "Reparou que o O botão inferior pode receber entrada, enquanto o botão superior não ?";
        }
    }
}
