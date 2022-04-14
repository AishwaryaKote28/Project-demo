using InstituteManagementSystem.Data;
using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace InstituteManagementSystem.Repo
{
    public class CourseDetailsRepo : ICourseDetails
    {
        DataBaseContext _context;
        public CourseDetailsRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<CourseDetailsVM> GetCourse()
        {
            // return _context.CourseDetails.ToList();
            var details = (from d in _context.CourseDetails
                           select new CourseDetailsVM {
                               CourseId = d.CourseId,
                               CourseName = d.CourseName,
                               Duration=d.Duration, 
                               Fees=d.Fees,
                               //StudentId=d.StudentId
                           }).ToList();
            return details;
        }
        public CourseDetails GetCourseID(int CourseId)
        {
            return _context.CourseDetails.FirstOrDefault(a => a.CourseId == CourseId);
        }
        public List<CourseDetails> GetCourseByName(string CourseName)
         {
            //return _context.CourseDetails(a => a.CourseName == CourseName).ToList();
            List<CourseDetails> CourseDetails = _context.CourseDetails.Where(s => s.CourseName.Equals(CourseName)).ToList();
            return CourseDetails;
        }
        public void AddCourse(CourseDetails CourseDetails)
        {
            _context.Add(CourseDetails);
            _context.SaveChanges();
        }
        public void UpdateCourse(CourseDetails CourseDetails)
        {
            _context.Update(CourseDetails);
            _context.SaveChanges();
        }
        public void DeleteCourse(int CourseId)
        {
            var DeleteCourse = _context.CourseDetails.Where(s => s.CourseId == CourseId).FirstOrDefault();
            if (DeleteCourse != null) {
                _context.Remove(DeleteCourse);
                _context.SaveChanges();
            }
        }
    }
}


  