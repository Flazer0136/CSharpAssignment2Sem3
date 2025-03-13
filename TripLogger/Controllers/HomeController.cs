using Microsoft.AspNetCore.Mvc;
using TripLogger.Models;

namespace TripLogger.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Trip> data { get; set; }
        public HomeController(TripLoggerContext ctx) => data = new Repository<Trip>(ctx);

        public ViewResult Index()
        {
            var options = new QueryOptions<Trip> { 
                Includes = "Destination, Accommodation, TripActivities.Activity",
                OrderBy = t => t.StartDate
            };

            var trips = data.List(options);
            return View(trips);
        }

    }
}
