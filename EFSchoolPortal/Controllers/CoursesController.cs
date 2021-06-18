using EFSchoolPortal.Data;
using EFSchoolPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Controllers
{
    public class CoursesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Courses()
        {
            List<Course> coursesList = _context.Courses.ToList();
            return View(coursesList);
        }
    }
}
