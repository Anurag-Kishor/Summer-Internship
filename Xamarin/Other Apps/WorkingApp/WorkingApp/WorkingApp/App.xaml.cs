using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("PlayfairDisplay-Black.ttf")]
[assembly: ExportFont("PlayfairDisplay-Bold.ttf")]
[assembly: ExportFont("PlayfairDisplay-Regular.ttf")]
[assembly: ExportFont("Roboto-Bold.ttf")]
[assembly: ExportFont("Roboto-Light.ttf")]
[assembly: ExportFont("Roboto-Regular.ttf")]
[assembly: ExportFont("Roboto-Thin.ttf")]


namespace WorkingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
