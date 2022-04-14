using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace InstituteManagementSystem.Service
{
    public class StudentAdmissionService
    {
        IStudentAdmisionDetails _service;
        public StudentAdmissionService(IStudentAdmisionDetails service)
        {
            _service = service;
        }
        public List<StudentAdmissionVM> GetStudentList()
        {
            return _service.GetStudentList().ToList();
        }
        public StudentAdmissionVM GetStudentID(int StudentId)
        {
            //return _service.StudentAdmissionVM.FirstOrDefault(e => e.StudentId == StudentId);
            return _service.GetStudentID(StudentId);
            //var result = (from s in _service.StudentAdmissionDetails
            //              select new StudentAdmissionVM {
            //                  StudentId = s.StudentId,
            //                  FirstName = s.FirstName,
            //                  LastName = s.LastName,
            //                  Gender = s.Gender,
            //                  Dob = s.Dob,
            //                  MobileNumber = s.MobileNumber,
            //                  AdharNumber = s.AdharNumber,
            //                  HighestQualification = s.HighestQualification,
            //                  AddressLine1 = s.AddressLine1,
            //                  AddressLine2 = s.AddressLine2,
            //                  City = s.City,
            //                  State = s.State,
            //                  Country = s.Country,
            //                  AdmissionDate = s.AdmissionDate
            //              }).FirstOrDefault();
            //return result;
        }
        public void AddStudent(StudentAdmissionVM studentadmissionvm)
        {
            StudentAdmissionDetails student = new StudentAdmissionDetails() {
                StudentId=studentadmissionvm.StudentId,
                FirstName = studentadmissionvm.FirstName,
                LastName = studentadmissionvm.LastName,
                Gender = studentadmissionvm.Gender,
                Dob = studentadmissionvm.Dob,
                MobileNumber = studentadmissionvm.MobileNumber,
                AdharNumber = studentadmissionvm.AdharNumber,
                HighestQualification = studentadmissionvm.HighestQualification,
                AddressLine1 = studentadmissionvm.AddressLine1,
                AddressLine2 = studentadmissionvm.AddressLine2,
                City = studentadmissionvm.City,
                State = studentadmissionvm.State,
                Country = studentadmissionvm.Country,
                AdmissionDate = studentadmissionvm.AdmissionDate,
                CourseId= studentadmissionvm.CourseId
            };
            _service.AddStudent(student); 
        }
        public void UpdateStudent(StudentAdmissionVM studentadmissionvm)
        {
            StudentAdmissionDetails student = new StudentAdmissionDetails() {
                StudentId = studentadmissionvm.StudentId,
                FirstName = studentadmissionvm.FirstName,
                LastName = studentadmissionvm.LastName,
                Gender = studentadmissionvm.Gender,
                Dob = studentadmissionvm.Dob,
                MobileNumber = studentadmissionvm.MobileNumber,
                AdharNumber = studentadmissionvm.AdharNumber,
                HighestQualification = studentadmissionvm.HighestQualification,
                AddressLine1 = studentadmissionvm.AddressLine1,
                AddressLine2 = studentadmissionvm.AddressLine2,
                City = studentadmissionvm.City,
                State = studentadmissionvm.State,
                Country = studentadmissionvm.Country,
                AdmissionDate = studentadmissionvm.AdmissionDate,
                CourseId = studentadmissionvm.CourseId

            };
            _service.UpdateStudent(student);
        }
        public void DeleteStudent(int StudentID)
        {
             _service.DeleteStudent(StudentID);
        }
    }    
}


