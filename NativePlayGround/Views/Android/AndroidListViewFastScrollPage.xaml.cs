using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using NativePlayGround.ViewModel;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidListViewFastScrollPage : ContentPage
    {
        public AndroidListViewFastScrollPage()
        {
            InitializeComponent();
            BindingContext = new ListViewViewModel();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            listView.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsFastScrollEnabled(!listView.On<Xamarin.Forms.PlatformConfiguration.Android>().IsFastScrollEnabled());
        }
    }
}
