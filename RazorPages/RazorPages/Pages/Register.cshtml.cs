using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserModel User { get; set; }

        public string Message { get; private set; }

        public void OnGet()
        {
            //Page load logic
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "You have been Successfully Registered";
                return new RedirectToPageResult("Confirmation", "Register");
            }
            return Page();
        }

        public IActionResult OnPostSubscribe(string email)
        {
            return new RedirectToPageResult("Confirmation", "Subscribe");
        }
    }
}