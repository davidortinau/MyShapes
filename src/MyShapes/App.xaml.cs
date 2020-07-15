using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyShapes
{
    public partial class App : Application
    {
        public App()
        {
            StyleSheetRegistrar.RegisterStyle("-xf-horizontal-options", typeof(VisualElement), nameof(View.HorizontalOptionsProperty));
            StyleSheetRegistrar.RegisterStyle("-xf-vertical-options", typeof(VisualElement), nameof(View.VerticalOptionsProperty));

            Device.SetFlags(new string[] { "Shapes_Experimental" });
            InitializeComponent();

            MainPage = new MainPage();
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
