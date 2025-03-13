using Microsoft.AspNetCore.Mvc;
using TripLogger.Models;

namespace TripLogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly TripLoggerContext _context;

        public HomeController(TripLoggerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var trips = _context.Trips
                .Select(t => new TripViewModel
                {
                    Id = t.Id,
                    Destination = t.Destination.Name,
                    Accommodation = t.Accommodation.Name,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    AccommodationPhoneNumber = t.AccommodationPhoneNumber,
                    AccommodationEmail = t.AccommodationEmail,
                    ThingsToDo = string.Join("\n ", t.TripActivities.Select(a => a.Activity.Name))
                })
                .ToList();

            return View(trips);
        }
    }
}
