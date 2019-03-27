using System;
using System.Collections.Generic;
using NativePlayGround.ViewModel;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSListViewPage : ContentPage
    {
        public iOSListViewPage()
        {
            InitializeComponent();
            BindingContext = new ListViewViewModel();
        }
    }
}
