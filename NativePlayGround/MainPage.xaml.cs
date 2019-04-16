using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NativePlayGround.Views;
using NativePlayGround.Views.Android;
using Xamarin.Forms;

namespace NativePlayGround
{
    public partial class MainPage : ContentPage
    {
        Page _originalRoot;
        public ICommand NavigateCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (pageType) => await NavigateToPage(pageType));
            BindingContext = this;

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
            {
                var btnBlur = new Button
                {
                    Text = "iOS Efeito Blur",
                };

                btnBlur.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSBlurEffectPage));

                MenuPrincipal.Children.Add(btnBlur);

                var btnEntry = new Button
                {
                    Text = "Tamanhos no Entry",
                };

                btnEntry.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSEntryPage));

                MenuPrincipal.Children.Add(btnEntry);

                var btnTitulo = new Button
                {
                    Text = "Aumentar o titulo da NavigationPage",
                };

                btnTitulo.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSLargeTitlePage));

                MenuPrincipal.Children.Add(btnTitulo);

                var btnPicker = new Button
                {
                    Text = "Opçoes de Picker",
                };

                btnPicker.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSPickerPage));

                MenuPrincipal.Children.Add(btnPicker);

                var btnSafeArea = new Button
                {
                    Text = "Safe Area",
                };

                btnSafeArea.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSSafeAreaPage));

                MenuPrincipal.Children.Add(btnSafeArea);

                var btnShadow = new Button
                {
                    Text = "Efeito de Sombra",
                };

                btnShadow.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSShadowEffectPage));

                MenuPrincipal.Children.Add(btnShadow);

                var btnSlider = new Button
                {
                    Text = "Slider",
                };

                btnSlider.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSSliderUpdateOnTapPage));

                MenuPrincipal.Children.Add(btnSlider);

                var btnStatusBar = new Button
                {
                    Text = "Status Bar",
                };

                btnStatusBar.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSStatusBarPage));

                MenuPrincipal.Children.Add(btnStatusBar);

                var btnNavigationBarTransparente = new Button
                {
                    Text = "NavigationBar Transparente",
                };

                btnNavigationBarTransparente.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSTranslucentNavigationBarPage));

                MenuPrincipal.Children.Add(btnNavigationBarTransparente);

                var btnModal = new Button
                {
                    Text = "Modal para Ipad",
                };

                btnModal.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSModalFormSheetPage));

                MenuPrincipal.Children.Add(btnModal);

                var btnTitleView = new Button
                {
                    Text = "Title View",
                };

                btnTitleView.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSTitleViewPage));

                MenuPrincipal.Children.Add(btnTitleView);

                var btnListView = new Button
                {
                    Text = "ListView Agrupada",
                };

                btnListView.Clicked += async (sender, e) => await NavigateToPage(typeof(iOSListViewPage));

                MenuPrincipal.Children.Add(btnListView);

            }
            else //Logo Mais dicas de Android
            {
                var btnShadow = new Button
                {
                    Text = "Sombra no botão",
                };

                btnShadow.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidButtonPage));

                MenuPrincipal.Children.Add(btnShadow);

                var btnElevation = new Button
                {
                    Text = "Elevação",
                };

                btnElevation.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidElevationPage));

                MenuPrincipal.Children.Add(btnElevation);

                var btnInput = new Button
                {
                    Text = "Opções de Entrada no Teclado",
                };

                btnInput.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidEntryPage));

                MenuPrincipal.Children.Add(btnInput);

                var btnImageShadow = new Button
                {
                    Text = "ImageButton Com Sombra",
                };

                btnImageShadow.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidImageButtonPage));

                MenuPrincipal.Children.Add(btnImageShadow);

                var btnPause = new Button
                {
                    Text = "Pause e Retorne o ciclo de vida do APP",
                };

                btnPause.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidLifecycleEventsPage));

                MenuPrincipal.Children.Add(btnPause);

                var btnFastScroll = new Button
                {
                    Text = "Habilitar FastScroll no ListView",
                };

                btnFastScroll.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidListViewFastScrollPage));

                MenuPrincipal.Children.Add(btnFastScroll);

                var btnTitleView = new Button
                {
                    Text = "Android TitleView",
                };

                btnTitleView.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidTitleViewPage));

                MenuPrincipal.Children.Add(btnTitleView);

                var btnTeclado = new Button
                {
                    Text = "Ajuste Teclado",
                };

                btnTeclado.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidSoftInputModeAdjustPage));

                MenuPrincipal.Children.Add(btnTeclado);

                var btnTabbar = new Button
                {
                    Text = "Opções de TabbedPage",
                };

                btnTabbar.Clicked += async (sender, e) => await NavigateToPage(typeof(AndroidTabbedPageSwipePage));

                MenuPrincipal.Children.Add(btnTabbar);


            }
        }

        async Task NavigateToPage(Type pageType)
        {
            Type[] types = new Type[] { typeof(Command) };
            ConstructorInfo info = pageType.GetConstructor(types);
            if (info != null)
            {
                Page page = (Page)Activator.CreateInstance(pageType, new Command(RestoreOriginal));
                if (page is iOSLargeTitlePage || page is iOSTranslucentNavigationBarPage)
                {
                    page = new iOSNavigationPage(page);
                }
                else if (page is iOSTitleViewPage)
                {
                    page = new iOSTitleViewNavigationPage(page);
                }
                else if (page is AndroidTitleViewPage)
                {
                    page = new AndroidNavigationPage(page);
                }
                SetRoot(page);
            }
            else
            {
                Page page = (Page)Activator.CreateInstance(pageType);

                
                if (page is iOSModalFormSheetPage)
                {
                    await Navigation.PushModalAsync(page);
                }
                else
                {
                    await Navigation.PushAsync(page);
                }

            }
        }

        void SetRoot(Page page)
        {
            var app = Application.Current as App;
            if (app == null)
            {
                return;
            }

            _originalRoot = app.MainPage;
            app.SetMainPage(page);
        }

        void RestoreOriginal()
        {
            if (_originalRoot == null)
            {
                return;
            }

            var app = Application.Current as App;
            app?.SetMainPage(_originalRoot);
        }
    }
}
