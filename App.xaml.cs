using AppTask.Views;

namespace AppTask
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new NavigationPage(new StartPage()); 
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new StartPage());
            
        }
    }
}