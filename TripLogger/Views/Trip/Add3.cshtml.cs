using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TripLogger.Views.Trip
{
    public class Add3Model : PageModel
    {
        [BindProperty]
        public TripPage3ViewModel TripPage3 { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Index");
        }
    }

}
