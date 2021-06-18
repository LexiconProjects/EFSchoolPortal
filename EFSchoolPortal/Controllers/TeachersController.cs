using EFSchoolPortal.Data;
using EFSchoolPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Controllers
{
    public class TeachersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TeachersController(ApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public IActionResult Teachers()
        {
            List<Teacher> teachersList = _context.Teachers.ToList();
            return View(teachersList);
        }

        public IActionResult RegisterTeacherView()
        {

            List<Course> coursesList = _context.Courses.ToList();
            ViewBag.CoursesList = coursesList;
            /*
            ViewBag.CoursesNames = new SelectList(_context.Courses, "Id", "Acronym");
           */

            
            List<SelectListItem> coursesDL = new List<SelectListItem>();
            coursesDL.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            int i = 0;
            var courses = _context.Courses.ToArray();
            foreach (var item in courses)
            {
                
                coursesDL.Add(new SelectListItem { Value = courses[i].ID.ToString(), Text = courses[i].Acronym });
                i++;
            }

            ViewBag.CoursesDL = coursesDL;
            

            /*
            IEnumerable<SelectListItem> coursesDropdown = _context.Courses.Select(c => new SelectListItem
            {
                Value = c.Acronym,
                Text = c.Acronym

            });
            ViewBag.CoursesNames = coursesDropdown;
            */

            return View("RegisterTeacher");
        }
        [HttpPost]
        public IActionResult RegisterTeacher(Teacher member, string courseId)
        {
            member.CourseId = Convert.ToInt32(courseId);
            if (String.IsNullOrEmpty(member.Fname) || String.IsNullOrEmpty(member.Lname) || String.IsNullOrEmpty(member.Email))
            {
                return RegisterTeacherView();
            }
            else
            {
                _context.Teachers.Add(member);
                _context.SaveChanges();
                return RedirectToAction("Teachers");
            }
        }

        public IActionResult CreateCourse()
        {
            return View();
        }
    }
}
