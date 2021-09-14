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

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "You have been Successfully Registered";
            }
        }

        public void OnPostSubscribe(string email)
        {
            if (!string.IsNullOrEmpty(email))
                Message = "You have been Successfully Subscribed";
        }
    }
}