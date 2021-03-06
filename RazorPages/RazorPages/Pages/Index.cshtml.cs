using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;
using System.Collections.Generic;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private ICourseService courseService;

        public List<Course> Courses { get; set; }

        public IndexModel(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public void OnGet()
        {
            Courses = courseService.GetCourses();
        }
    }
}