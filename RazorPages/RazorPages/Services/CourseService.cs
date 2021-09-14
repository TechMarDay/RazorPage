using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public class CourseService : ICourseService
    {
        public List<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Slug = "Javascript-basic",
                    Name = "Javascript cơ bản",
                    Discount = 5,
                    Summary = "Học Javascript cơ bản phù hợp cho người chưa từng học lập trình. ",
                    Description = @"Học Javascript cơ bản phù hợp cho người chưa từng học lập trình. Với hơn 100 bài học và có bài tập thực hành sau mỗi bài học.",
                    ImageFile = "JavascriptBasic.png"
                },
                new Course()
                {
                    Id = 2,
                    Slug = "Reactjs",
                    Name = "Reactjs",
                    Discount = 15,
                    Summary = "Kiến thức nền tảng của ReactJS đầy đủ để mọi người tham khảo đầy đủ",
                    Description = @"Khoá học ReactJS đầy đủ để mọi người tham khảo đầy đủ, trọn vẹn về ReactJS, giúp các bạn tự tin hơn khi làm việc với ReactJS.",
                    ImageFile = "Reactjs.png"
                },
                new Course()
                {
                    Id = 3,
                    Slug = "Typescript",
                    Name = "Typescript",
                    Discount = 90,
                    Summary = "Khóa học lập trình TypeScript cung cấp các kiến thức trọng tâm",
                    Description = @"Khóa học lập trình TypeScript cung cấp các kiến thức trọng tâm về TypeScript cũng như cách áp dụng và kết hợp TypeScript với jQuery,các thư viện jQuery",
                    ImageFile = "Typescript.png"
                }
            };
        }
    }
}