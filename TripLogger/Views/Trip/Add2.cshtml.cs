using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TripLogger.Views.Trip
{
    public class Add2Model : PageModel
    {
        [BindProperty]
        public TripPage2ViewModel TripPage2 { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Add3");
        }
    }

}
