using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfDay3Exercise05;

public class RunnerFormViewModel : INotifyPropertyChanged
{
    private string _runnerName = "Anna Nowak";

    public string RunnerName
    {
        get => _runnerName;
        set
        {
            if (_runnerName == value) return;
            _runnerName = value;
            OnPropertyChanged();
        }
    }

    public ICommand SaveRunnerCommand { get; }

    public RunnerFormViewModel()
    {
        SaveRunnerCommand = new RelayCommand(_ => MessageBus.Send(new RunnerSavedMessage(RunnerName)));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
