using System.Windows;
using WpfDay3Exercise01.ViewModels;

namespace WpfDay3Exercise01;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new RunnerProfileViewModel();
    }
}
