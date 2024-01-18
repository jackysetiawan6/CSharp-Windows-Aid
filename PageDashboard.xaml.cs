using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
//using MUXC = Microsoft.UI.Xaml.Controls;

namespace CSharp_Windows_Aid
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SetWindowTitleBarTransparent(false);
        }

        private void WindowsAid_Loaded(object _, RoutedEventArgs e)
        {
            ClassMonitor classMonitor = new ClassMonitor(this);
            classMonitor.Activate();
        }

        private void SetWindowTitleBarTransparent(bool option)
        {
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            if (!option)
            {
                coreTitleBar.ExtendViewIntoTitleBar = false;
                titleBar.ButtonBackgroundColor = (Color)Resources["SystemAccentColor"];
                titleBar.ButtonInactiveBackgroundColor = (Color)Resources["SystemAccentColor"];
                return;
            }
            coreTitleBar.ExtendViewIntoTitleBar = true;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
    }
}