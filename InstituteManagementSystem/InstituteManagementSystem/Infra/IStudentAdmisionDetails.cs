using InstituteManagementSystem.ViewModel;
using System.Collections.Generic;

namespace InstituteManagementSystem.Infra
{
    public interface IStudentAdmisionDetails
    {
        public List<StudentAdmissionVM> GetStudentList();
        public StudentAdmissionVM GetStudentID(int StudentId);
        public StudentAdmissionVM AddStudent(StudentAdmissionVM Student);
        public StudentAdmissionVM UpdateStudent(StudentAdmissionVM Student);
        public void DeleteStudent(int Student);
    }
}
