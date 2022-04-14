using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.ViewModel
{
    public class CourseDetailsVM
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }     
      //  public int StudentId { get; set; }
    }
}
