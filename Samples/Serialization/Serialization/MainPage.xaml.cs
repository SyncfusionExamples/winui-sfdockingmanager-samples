using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Serialization
{
    /// <summary>
    /// The main content page displayed inside the application window.
    /// Add your UI logic, event handlers, and data binding here.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly string layoutPath =
    Path.Combine(ApplicationData.Current.LocalFolder.Path, "DockLayout.xml");
        public MainPage()
        {
            InitializeComponent();

            // TODO: Add your initialization logic here.
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream stream = File.Create(layoutPath))
            {
                dockingManager.SaveLayout(stream);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(layoutPath))
            {
                return;
            }

            using (FileStream stream = File.OpenRead(layoutPath))
            {
                dockingManager.LoadLayout(stream);
            }
        }
    }
}
