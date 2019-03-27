using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class iOSTitleViewPage : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public iOSTitleViewPage(ICommand restore)
        {
            InitializeComponent();

            _returnToPlatformSpecificsPage = restore;
            _searchBar.Effects.Add(Effect.Resolve("XamarinDocs.SearchBarEffect"));
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
