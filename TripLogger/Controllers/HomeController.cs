﻿using Microsoft.AspNetCore.Mvc;
using TripLogger.Models;
using System.Linq;

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
                    Destination = t.Destination,
                    Accommodation = t.Accommodation,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    AccommodationPhoneNumber = t.AccommodationPhoneNumber,
                    AccommodationEmail = t.AccommodationEmail,
                    ThingsToDo = t.TripActivity
                })
                .ToList();

            return View(trips);
        }
    }
}
