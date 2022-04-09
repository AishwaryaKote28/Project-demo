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
        public StudentAdmissionVM AddStudent(StudentAdmissionVM StudentAdmissionVM)
        {
            StudentAdmissionDetails Student = new StudentAdmissionDetails() {
                FirstName = StudentAdmissionVM.FirstName,
                LastName = StudentAdmissionVM.LastName,
                Gender = StudentAdmissionVM.Gender,
                Dob = StudentAdmissionVM.Dob,
                MobileNumber = StudentAdmissionVM.MobileNumber,
                AdharNumber = StudentAdmissionVM.AdharNumber,
                HighestQualification = StudentAdmissionVM.HighestQualification,
                AddressLine1 = StudentAdmissionVM.AddressLine1,
                AddressLine2 = StudentAdmissionVM.AddressLine2,
                City = StudentAdmissionVM.City,
                State = StudentAdmissionVM.State,
                Country = StudentAdmissionVM.Country,
                AdmissionDate = StudentAdmissionVM.AdmissionDate
            };
           return  _service.AddStudent(StudentAdmissionVM);
        }
        public StudentAdmissionVM UpdateStudent(StudentAdmissionVM StudentAdmissionVM)
        {
            StudentAdmissionDetails Student = new StudentAdmissionDetails() {
                FirstName = StudentAdmissionVM.FirstName,
                LastName = StudentAdmissionVM.LastName,
                Gender = StudentAdmissionVM.Gender,
                Dob = StudentAdmissionVM.Dob,
                MobileNumber = StudentAdmissionVM.MobileNumber,
                AdharNumber = StudentAdmissionVM.AdharNumber,
                HighestQualification = StudentAdmissionVM.HighestQualification,
                AddressLine1 = StudentAdmissionVM.AddressLine1,
                AddressLine2 = StudentAdmissionVM.AddressLine2,
                City = StudentAdmissionVM.City,
                State = StudentAdmissionVM.State,
                Country = StudentAdmissionVM.Country,
            };
           return _service.UpdateStudent(StudentAdmissionVM);
        }
        public void DeleteStudent(int StudentID)
        {
             _service.DeleteStudent(StudentID);
        }
    }    
}


