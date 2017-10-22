using NFileSystem;
using AdvancedFusionLogViewer.Models.Logic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AdvancedFusionLogViewer.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();

            var x = new LogDirectoryWalker().Load(new Directory(@"C:\temp\fusionlog"));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
