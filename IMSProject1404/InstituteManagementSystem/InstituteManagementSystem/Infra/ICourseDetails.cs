using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System.Collections.Generic;

namespace InstituteManagementSystem.Infra
{
    public interface ICourseDetails
    {
        public List<CourseDetailsVM> GetCourse();
        public CourseDetails GetCourseID(int CourseId);
        public List<CourseDetails> GetCourseByName(string CourseName);
        public void AddCourse(CourseDetails CourseDetails);
        public void UpdateCourse(CourseDetails CourseDetails);
        public void DeleteCourse(int CourseId);
    }
}
