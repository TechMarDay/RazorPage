using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public interface ICourseService
    {
        List<Course> GetCourses();
    }
}