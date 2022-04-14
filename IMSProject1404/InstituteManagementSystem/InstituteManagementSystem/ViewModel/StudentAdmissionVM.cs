using InstituteManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace InstituteManagementSystem.ViewModel
{
    public class StudentAdmissionVM
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
        public string MobileNumber { get; set; }
        public string AdharNumber { get; set; }
        public string HighestQualification { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int CourseId { get; set; }
        public virtual CourseDetails CourseDetails { get; set; }
    }
}
