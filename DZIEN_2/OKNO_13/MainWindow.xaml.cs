using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfDay2Exercise05;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}

public class MainViewModel : INotifyPropertyChanged
{
    private string _selectedDistance;

    public MainViewModel()
    {
        _selectedDistance = Distances[0];
    }

    public List<string> Distances { get; } = new()
    {
        "Trail 33 km",
        "Ultra 45 km",
        "Winter 50 km",
        "Vertical 10 km"
    };

    public string SelectedDistance
    {
        get => _selectedDistance;
        set
        {
            if (_selectedDistance == value) return;
            _selectedDistance = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
