using Xamarin.Forms;

namespace TestXFMac
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new GridDemoPage();
            //MainPage = new HelloXamlPage();
            //MainPage = new AbsoluteDemoPage();
            //MainPage = new XamlPlusCodePage();
            //MainPage = new SharedResourcesPage();
            //MainPage = new SliderBindingsPage();
            //MainPage = new OneShotDateTimePage();

            //MainPage = new ClockPage();
            //MainPage = new HslColorScrollPage();
            MainPage = new MyBinding();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
             //Handle when your app resumes
        }
    }
}
