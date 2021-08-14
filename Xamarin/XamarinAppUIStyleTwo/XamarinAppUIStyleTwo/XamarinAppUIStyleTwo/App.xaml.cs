using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "OpenSansRegular")]
[assembly: ExportFont("OpenSans-Light.ttf", Alias = "OpenSansLight")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "OpenSansBold")]
[assembly: ExportFont("OpenSans-ExtraBold.ttf", Alias = "OpenSansExtraBold")]
[assembly: ExportFont("OpenSans-LightItalic.ttf", Alias = "OpenSansLightItalic")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "OpenSansSemiBold")]

[assembly: ExportFont("Poppins-Black.ttf", Alias = "PoppinsBlack")]
[assembly: ExportFont("Poppins-Bold.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("Poppins-Italic.ttf", Alias = "PoppinsItalic")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "PoppinsMedium")]
[assembly: ExportFont("Poppins-Regular.ttf", Alias = "PoppinsRegular")]
[assembly: ExportFont("Poppins-SemiBold.ttf", Alias = "PoppinsSemiBold")]

namespace XamarinAppUIStyleTwo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SetupPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
