using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Models
{
    public class Teacher
    {

        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
