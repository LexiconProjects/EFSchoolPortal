using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Models
{
    public class Student
    {

        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
