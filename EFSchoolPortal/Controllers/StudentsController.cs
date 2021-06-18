using EFSchoolPortal.Data;
using EFSchoolPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Students()
        {
            List<Student> studentsList = _context.Students.ToList();
            return View(studentsList);
        }

        public IActionResult RegisterStudentView()
        {
            return View("RegisterStudent");
        }


        public IActionResult EnrollStudentView()
        {
            return View("EnrollStudent");
        }

        [HttpPost]
        public ActionResult RegisterStudent(Student member)
        {
            if (String.IsNullOrEmpty(member.Fname) || String.IsNullOrEmpty(member.Lname) || String.IsNullOrEmpty(member.Email))
            {
                return View();
            }
            else
            {
                _context.Students.Add(member);
                _context.SaveChanges();
                return RedirectToAction("Students");
            }
        }
        public IActionResult RegisterStudent()
        {
            return View();
        }
    }
}
