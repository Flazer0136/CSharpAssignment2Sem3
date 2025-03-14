using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripLogger.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string? Accommodation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? AccommodationPhoneNumber { get; set; }
        public string? AccommodationEmail { get; set; }
        public string? TripActivity { get; set; }
    }

}
