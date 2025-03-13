using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripLogger.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public Destination Destination { get; set; }
        public Accommodation? Accommodation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? AccommodationPhoneNumber { get; set; }
        public string? AccommodationEmail { get; set; }
        public ICollection<TripActivity> TripActivities { get; set; }
    }

}
