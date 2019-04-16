﻿using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;


namespace NativePlayGround.Views.Android
{
    public partial class AndroidLifecycleEventsPage : ContentPage
    {
        public AndroidLifecycleEventsPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>()
                   .SendDisappearingEventOnPause(!Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().GetSendDisappearingEventOnPause())
                   .SendAppearingEventOnResume(!Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().GetSendAppearingEventOnResume())
                   .ShouldPreserveKeyboardOnResume(!Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().GetShouldPreserveKeyboardOnResume());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("\r\n\t\tOnAppearing\r\n");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("\r\n\t\tOnDisappearing\r\n");
        }
    }
}
