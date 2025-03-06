using AppTask.Views;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;

namespace AppTask
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CustomHandler();

            // MainPage = new NavigationPage(new StartPage()); 
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new StartPage());

        }

        private void CustomHandler()
        {
            EntryNoBorder();
            DatePickerNoBorder();

        }

        private static void EntryNoBorder()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
                //Condicionais de compilação
#if ANDROID
                    //ANDROID
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif
#if IOS || MACCATALYST
                //IOS || MACCATALYST
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
#if WINDOWS
                // WINDOWS não funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }

        private static void DatePickerNoBorder()
        {
            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
                //Condicionais de compilação
#if ANDROID
                    //ANDROID
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif
#if IOS || MACCATALYST
                //IOS || MACCATALYST
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
#if WINDOWS
                // WINDOWS não funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }
    }            
    
}