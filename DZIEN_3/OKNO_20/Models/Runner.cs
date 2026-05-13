namespace WpfDay3Exercise01.Models;

public class Runner
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Distance { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";
}
