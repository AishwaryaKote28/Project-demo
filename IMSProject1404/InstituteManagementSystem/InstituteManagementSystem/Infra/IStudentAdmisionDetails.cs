using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System.Collections.Generic;

namespace InstituteManagementSystem.Infra
{
    public interface IStudentAdmisionDetails
    {
        public List<StudentAdmissionVM> GetStudentList();
        public StudentAdmissionVM GetStudentID(int StudentId);
        public void AddStudent(StudentAdmissionDetails StudentAdmissionDetails);
        public void UpdateStudent(StudentAdmissionDetails StudentAdmissionDetails);
        public void DeleteStudent(int Student);
    }
}
