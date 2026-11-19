using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Themes
{
    /// <summary>
    /// The main content page displayed inside the application window.
    /// Add your UI logic, event handlers, and data binding here.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // TODO: Add your initialization logic here.
        }

        private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
             this.RequestedTheme = ElementTheme.Light;
        }

        private void Button_Click_1(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.RequestedTheme = ElementTheme.Dark;
        }
    }
}
