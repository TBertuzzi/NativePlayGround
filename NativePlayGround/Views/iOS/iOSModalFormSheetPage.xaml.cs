using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSModalFormSheetPage : ContentPage
    {
        public iOSModalFormSheetPage()
        {
            InitializeComponent();
        }

        async void OnReturnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
