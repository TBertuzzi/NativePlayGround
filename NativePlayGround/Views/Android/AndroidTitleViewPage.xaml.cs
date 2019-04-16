using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidTitleViewPage : ContentPage
    {
   
        ICommand _returnToPlatformSpecificsPage;

        public AndroidTitleViewPage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
