using WpfDay3Exercise01.Models;

namespace WpfDay3Exercise01.ViewModels;

public class RunnerProfileViewModel
{
    public string ScreenTitle { get; } = "Profil zawodnika - MVVM";

    public Runner Runner { get; } = new Runner
    {
        FirstName = "Anna",
        LastName = "Nowak",
        Distance = "Ultra 45 km"
    };
}
