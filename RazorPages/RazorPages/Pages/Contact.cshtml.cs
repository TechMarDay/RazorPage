using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.Pages
{
    public class ContactModel : PageModel
    {
        //(SupportsGet = true) mặc định BindProperty không binding khi truy cập http get, 
        //set SupportsGet = true sẽ hỗ trợ http get
        [BindProperty]
        public Contact Contact { get; set; }

        public string Message { get; private set; }

        [BindProperty]
        public int Id { get; set; }

        public void OnGet(int? id, string name)
        {
            if (id != null)
                Message = $"Id: {id} ";

            if (!string.IsNullOrEmpty(name))
                Message += $"Name: {name}";
        }

        public void OnPost([FromForm] Contact contact)
        {
            if (ModelState.IsValid)
            {
                var name = Request.Form["Contact.Name"];
                var email = Request.Form["Contact.Email"];
                EmailService.SendMail(contact);
                Message = $"Hi {name}, Your email - {email} was sent to our team.";
            }
        }
    }
}