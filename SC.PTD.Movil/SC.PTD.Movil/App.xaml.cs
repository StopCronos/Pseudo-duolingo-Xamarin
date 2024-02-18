
using SC.PTD.Movil.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Spongeboy Me Bob.ttf", Alias = "bobSponja")]
[assembly: ExportFont("Amatic-Bold.ttf")]

namespace SC.PTD.Movil
{
    public partial class App : Application
    {
        public string MyProperty { get; set; }
        public App()
        {
            InitializeComponent();
            MyProperty = "AbecedarioPage";
            MainPage = new NavigationPage(new AbecedarioPage());
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
