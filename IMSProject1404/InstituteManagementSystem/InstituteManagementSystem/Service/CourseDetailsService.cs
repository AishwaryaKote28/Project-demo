using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Service
{
    public class CourseDetailsService
    {
        ICourseDetails _service;
        public CourseDetailsService(ICourseDetails service)
        {
            _service = service;
        }
        public List<CourseDetailsVM> GetCourse()
        {
            return _service.GetCourse().ToList();
            //List<Supplier> supplier = _sservice.GetSupplier();
            // return supplier.ToList();
        }
        public CourseDetails GetCourseID(int CourseId)
        {
            return _service.GetCourseID(CourseId);
        }
        public List<CourseDetails> GetCourseByName(string CourseName)
        {
            //return _context.CourseDetails(a => a.CourseName == CourseName).ToList();
           // List<CourseDetails> CourseDetails = _service.CourseDetails.Where(s => s.CourseName.Equals(CourseName)).ToList();
            return _service.GetCourseByName(CourseName); 
        }
        public void AddCourse(CourseDetailsVM courseDetailsVM)
        {
            CourseDetails courseDetails = new CourseDetails() {
                CourseId = courseDetailsVM.CourseId,
                CourseName = courseDetailsVM.CourseName,
                Duration = courseDetailsVM.Duration,
                Fees = courseDetailsVM.Fees,
                //StudentId=courseDetailsVM.StudentId
            };
            _service.AddCourse(courseDetails);
        }
        public void UpdateCourse(CourseDetailsVM courseDetailsVM)
        {
            CourseDetails courseDetails = new CourseDetails()
            {
                CourseId = courseDetailsVM.CourseId,
                CourseName = courseDetailsVM.CourseName,
                Duration = courseDetailsVM.Duration,
                Fees = courseDetailsVM.Fees,
                //StudentId = courseDetailsVM.StudentId
            };
            _service.UpdateCourse(courseDetails);
        }
        public void DeleteCourse(int CourseId)
        {
            _service.DeleteCourse(CourseId);
        }
    }
}

