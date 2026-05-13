using System.Windows;

namespace WpfDay3Exercise02;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new TrainingCounterViewModel();
    }
}
