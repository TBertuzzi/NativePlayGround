using System;
using System.Windows.Input;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using Xamarin.Forms;

namespace NativePlayGround.Views.Android
{
    public partial class AndroidTabbedPageSwipePage : Xamarin.Forms.TabbedPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public AndroidTabbedPageSwipePage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnSwipePagingButtonClicked(object sender, EventArgs e)
        {
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(!On<Xamarin.Forms.PlatformConfiguration.Android>().IsSwipePagingEnabled());
        }

        void OnSmoothScrollButtonClicked(object sender, EventArgs e)
        {
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(!On<Xamarin.Forms.PlatformConfiguration.Android>().IsSmoothScrollEnabled());
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
