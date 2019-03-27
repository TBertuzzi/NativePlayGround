using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSNavigationPage : NavigationPage
    {
        public iOSNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}
