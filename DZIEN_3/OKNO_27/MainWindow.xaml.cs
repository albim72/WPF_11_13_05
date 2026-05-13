using System.Windows;
using WpfDay3Exercise07.ViewModels;

namespace WpfDay3Exercise07;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new RunnerViewModel();
    }
}
