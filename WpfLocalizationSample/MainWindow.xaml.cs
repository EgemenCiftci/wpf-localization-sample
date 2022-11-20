using System.Windows;

namespace WpfLocalizationSample;

public partial class MainWindow : Window
{
    public string[] Items { get; set; } = new[]
        {
            "Item0",
            "Item1",
        };

    public MainWindow()
    {
        InitializeComponent();
    }
}
