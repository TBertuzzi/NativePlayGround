using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSTitleViewNavigationPage : NavigationPage
    {
        public iOSTitleViewNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}
