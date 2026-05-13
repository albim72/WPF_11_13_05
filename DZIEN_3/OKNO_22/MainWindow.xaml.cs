using System.Windows;

namespace WpfDay3Exercise03;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new RunnersViewModel();
    }
}
