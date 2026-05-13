using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfDay3Exercise03;

public class RunnersViewModel : INotifyPropertyChanged
{
    private string _newRunnerName = string.Empty;
    private readonly RelayCommand _addRunnerCommand;

    public ObservableCollection<string> Runners { get; } = new();

    public string NewRunnerName
    {
        get => _newRunnerName;
        set
        {
            if (_newRunnerName == value) return;
            _newRunnerName = value;
            OnPropertyChanged();
            _addRunnerCommand.RaiseCanExecuteChanged();
        }
    }

    public ICommand AddRunnerCommand => _addRunnerCommand;

    public RunnersViewModel()
    {
        Runners.Add("Jan Kowalski");
        _addRunnerCommand = new RelayCommand(_ => AddRunner(), _ => CanAddRunner());
    }

    private bool CanAddRunner() => !string.IsNullOrWhiteSpace(NewRunnerName);

    private void AddRunner()
    {
        Runners.Add(NewRunnerName.Trim());
        NewRunnerName = string.Empty;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
