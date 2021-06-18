using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Acronym { get; set; }
        public string Topic { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
