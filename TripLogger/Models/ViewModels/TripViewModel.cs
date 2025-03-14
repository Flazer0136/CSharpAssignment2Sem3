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
    public string AccommodationEmail { get; set; }
    public string AccommodationPhoneNumber { get; set; }
}

public class TripPage3ViewModel
{
    public string? ThingToDo1 { get; set; }
    public string? ThingToDo2 { get; set; }
    public string? ThingToDo3 { get; set; }
}

