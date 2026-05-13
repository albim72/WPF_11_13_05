using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfDay3Exercise07.ViewModels;

public partial class RunnerViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    private string firstName = "Anna";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    private string lastName = "Nowak";

    public string FullName => $"{FirstName} {LastName}";
}
