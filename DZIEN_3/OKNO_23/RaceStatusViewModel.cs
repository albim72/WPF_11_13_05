using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfDay3Exercise04;

public class RaceStatusViewModel : INotifyPropertyChanged
{
    private Runner? _selectedRunner;
    private readonly RelayCommand _setStatusCommand;

    public ObservableCollection<Runner> Runners { get; } = new();

    public Runner? SelectedRunner
    {
        get => _selectedRunner;
        set
        {
            if (_selectedRunner == value) return;
            _selectedRunner = value;
            OnPropertyChanged();
            _setStatusCommand.RaiseCanExecuteChanged();
        }
    }

    public ICommand SetStatusCommand => _setStatusCommand;

    public RaceStatusViewModel()
    {
        Runners.Add(new Runner("Anna Nowak", "brak"));
        Runners.Add(new Runner("Jan Kowalski", "brak"));
        Runners.Add(new Runner("Piotr Zieliński", "brak"));
        _setStatusCommand = new RelayCommand(SetStatus, _ => SelectedRunner != null);
    }

    private void SetStatus(object? parameter)
    {
        if (SelectedRunner == null || parameter is not string status) return;
        SelectedRunner.Status = status;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public class Runner : INotifyPropertyChanged
{
    private string _status;
    public string Name { get; }

    public string Status
    {
        get => _status;
        set
        {
            if (_status == value) return;
            _status = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(DisplayName));
        }
    }

    public string DisplayName => $"{Name} - status: {Status}";

    public Runner(string name, string status)
    {
        Name = name;
        _status = status;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
