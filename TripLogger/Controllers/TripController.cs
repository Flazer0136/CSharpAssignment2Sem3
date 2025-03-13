using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TripLogger.Models;

public class TripController : Controller
{
    private readonly TripLoggerContext _context;

    public TripController(TripLoggerContext context)
    {
        _context = context;
    }

    public IActionResult Add1()
    {
        return View(new TripPage1ViewModel());
    }

    [HttpPost]
    public IActionResult Add1(TripPage1ViewModel model)
    {
        if (ModelState.IsValid)
        {
            TempData["TripPage1"] = JsonConvert.SerializeObject(model);
            if (!string.IsNullOrEmpty(model.Accommodation))
            {
                return RedirectToAction("Add2");
            }
            return RedirectToAction("Add3");
        }
        return View(model);
    }

    public IActionResult Add2()
    {
        var model = new TripPage2ViewModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult Add2(TripPage2ViewModel model)
    {
        if (ModelState.IsValid)
        {
            TempData["TripPage2"] = JsonConvert.SerializeObject(model);
            return RedirectToAction("Add3");
        }
        return View(model);
    }

    public IActionResult Add3()
    {
        var model = new TripPage3ViewModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult Add3(TripPage3ViewModel model)
    {
        if (ModelState.IsValid)
        {
            var tripPage1 = JsonConvert.DeserializeObject<TripPage1ViewModel>(TempData["TripPage1"] as string);
            var tripPage2 = TempData.ContainsKey("TripPage2") ? JsonConvert.DeserializeObject<TripPage2ViewModel>(TempData["TripPage2"] as string) : null;

            var trip = new Trip
            {
                Destination = new Destination { Name = tripPage1.Destination },
                Accommodation = string.IsNullOrEmpty(tripPage1.Accommodation) ? null : new Accommodation
                {
                    Name = tripPage1.Accommodation,
                    Phone = tripPage2?.AccommodationPhoneNumber,
                    Email = tripPage2?.AccommodationEmail
                },
                StartDate = tripPage1.StartDate,
                EndDate = tripPage1.EndDate,
                TripActivities = model.ThingsToDo.Select(thing => new TripActivity
                {
                    Activity = new Activity { Name = thing }
                }).ToList()
            };

            _context.Trips.Add(trip);
            _context.SaveChanges();

            TempData.Clear();
            TempData["Message"] = "Trip has been added successfully!";
            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }

    public IActionResult Cancel()
    {
        TempData.Clear();
        return RedirectToAction("Index", "Home");
    }
}
