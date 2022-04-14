using System.ComponentModel.DataAnnotations;

namespace InstituteManagementSystem.Model
{
    public class CourseDetails
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        //[ForeignKey("StudentAdmissionDetails")]
        //public int StudentId { get; set; }
        //public virtual StudentAdmissionDetails StudentAdmissionDetails { get; set; }
        //public ICollection<StudentAdmissionDetails> StudentAdmissionDetails{get;set;}
    }
}
