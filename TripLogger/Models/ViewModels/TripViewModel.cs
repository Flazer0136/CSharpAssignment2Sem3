using System.ComponentModel.DataAnnotations;

public class TripViewModel
{
    public int Id { get; set; }
    public int PageNumber { get; set; }
    public string Destination { get; set; }
    public string? Accommodation { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? AccommodationEmail { get; set; }
    public string? AccommodationPhoneNumber { get; set; }
    public string ThingsToDo { get; set; }
}


public class TripPage1ViewModel
{
    public string Destination { get; set; }
    public string? Accommodation { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class TripPage2ViewModel
{
    public string? AccommodationEmail { get; set; }
    public string? AccommodationPhoneNumber { get; set; }
}

public class TripPage3ViewModel
{
    public List<string> ThingsToDo { get; set; } = new List<string>();

    [Display(Name = "Things to Do")]
    public string ThingsToDoString
    {
        get => string.Join(Environment.NewLine, ThingsToDo);
        set => ThingsToDo = value?.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>();
    }
}
