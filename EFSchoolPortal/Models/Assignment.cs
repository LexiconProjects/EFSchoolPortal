using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSchoolPortal.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DueDate { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }


    }
}
