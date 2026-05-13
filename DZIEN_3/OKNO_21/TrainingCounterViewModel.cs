using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfDay3Exercise02;

public class TrainingCounterViewModel : INotifyPropertyChanged
{
    private int _trainingCount;

    public int TrainingCount
    {
        get => _trainingCount;
        set
        {
            if (_trainingCount == value) return;
            _trainingCount = value;
            OnPropertyChanged();
        }
    }

    public ICommand AddTrainingCommand { get; }

    public TrainingCounterViewModel()
    {
        AddTrainingCommand = new RelayCommand(_ => TrainingCount++);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
