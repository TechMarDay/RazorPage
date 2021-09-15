using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGetRegister()
        {
            Message = "You have been Successfully Registered";
        }

        public void OnGetSubscribe()
        {
            Message = "You have been Successfully Subscribed";
        }
    }
}