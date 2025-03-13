using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TripLogger.Views.Trip
{
    public class Add1Model : PageModel
    {
        [BindProperty]
        public TripPage1ViewModel TripPage1 { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (string.IsNullOrEmpty(TripPage1.Accommodation))
            {
                return RedirectToPage("Add3");
            }
            else
            {
                return RedirectToPage("Add2");
            }
        }
    }

}
