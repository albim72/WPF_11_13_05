using System.Windows;

namespace WpfDay3Exercise04;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new RaceStatusViewModel();
    }
}
