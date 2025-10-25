using AppWiglaTCC.Views;

namespace AppWiglaTCC

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            UserAppTheme = AppTheme.Light;
            Application.Current.Resources["NavigationPageBarBackgroundColor"] = Colors.Blue;
            Application.Current.Resources["NavigationPageBarTextColor"] = Colors.White;


            MainPage = new NavigationPage(new Views.LoginPage());
            
        }
    }
}
