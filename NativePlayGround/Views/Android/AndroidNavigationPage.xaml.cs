using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidNavigationPage : NavigationPage
    {
        public AndroidNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}
