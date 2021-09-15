using Microsoft.AspNetCore.Mvc;
using RazorPages.Models;
using RazorPages.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages
{
    public class CoursesComponent : ViewComponent
    {
        private ICourseService courseService;

        public List<Course> Courses { get; set; }

        public CoursesComponent(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            return View(courseService.GetCourses().Take(count));
        }
    }
}
