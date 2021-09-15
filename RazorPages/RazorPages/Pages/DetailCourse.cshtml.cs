using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;
using System.Collections.Generic;
using System.Linq;

namespace RazorPages.Pages
{
    public class DetailCourseModel : PageModel
    {
        public Course Course { get; set; }

        private ICourseService courseService;

        public List<Course> Courses { get; set; }

        public DetailCourseModel(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public void OnGet(string slug)
        {
            Course = courseService.GetCourses().FirstOrDefault(x => x.Slug == slug);
        }
    }
}