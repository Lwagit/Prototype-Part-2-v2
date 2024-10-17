using Microsoft.AspNetCore.Mvc;

namespace StudentApp.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext context;

        public CoursesController(ApplicationDbContext context)
        {
            this.context = context;
        
        }

        public IActionResult Index()
        {
            var courses = context.Courses.ToList();
            return View(courses);
        }
    }
}
