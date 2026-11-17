using Microsoft.UI.Xaml;

namespace DockAbility
{
    /// <summary>
    /// The application window. This hosts a Frame that displays pages.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);

            AppWindow.SetIcon("Assets/AppIcon.ico");

            RootFrame.Navigate(typeof(MainPage));
        }
    }
}
