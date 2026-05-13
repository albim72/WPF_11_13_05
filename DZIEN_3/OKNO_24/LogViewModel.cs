using System.Collections.ObjectModel;

namespace WpfDay3Exercise05;

public class LogViewModel
{
    public ObservableCollection<string> Messages { get; } = new();

    public LogViewModel()
    {
        MessageBus.Subscribe(message => Messages.Add($"Zapisano zawodnika: {message.RunnerName}"));
    }
}
