using InstituteManagementSystem.Data;
using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InstituteManagementSystem.Repo
{
    public class SudentAdmissionRepo : IStudentAdmisionDetails
    {
        DataBaseContext _context;
        public SudentAdmissionRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<StudentAdmissionVM> GetStudentList()
        {
            //try {
            var result = (from s in _context.StudentAdmissionDetails
                          select new StudentAdmissionVM {
                              StudentId = s.StudentId,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              Gender = s.Gender,
                              Dob = s.Dob,
                              MobileNumber = s.MobileNumber,
                              AdharNumber = s.AdharNumber,
                              HighestQualification = s.HighestQualification,
                              AddressLine1 = s.AddressLine1,
                              AddressLine2 = s.AddressLine2,
                              City = s.City,
                              State = s.State,
                              Country = s.Country,
                              AdmissionDate = s.AdmissionDate
                          }).ToList();
            return result;
            // }
            //catch (Exception) {
            //    return StatusCodes(StatusCodes.Status500InternalServerError,
            //        "Error retrieving data from the database");
            //}
        }
        public StudentAdmissionVM GetStudentID(int StudentId)
        {
            var result = (from s in _context.StudentAdmissionDetails
                          select new StudentAdmissionVM {
                              StudentId = s.StudentId,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              Gender = s.Gender,
                              Dob = s.Dob,
                              MobileNumber = s.MobileNumber,
                              AdharNumber = s.AdharNumber,
                              HighestQualification = s.HighestQualification,
                              AddressLine1 = s.AddressLine1,
                              AddressLine2 = s.AddressLine2,
                              City = s.City,
                              State = s.State,
                              Country = s.Country,
                              AdmissionDate = s.AdmissionDate
                          }).FirstOrDefault();
            return result;
        }
        public StudentAdmissionVM AddStudent(StudentAdmissionVM studentAdmissionVM)
        {
            var result = _context.Add(studentAdmissionVM);
            _context.SaveChanges();
            return result.Entity;
        }
        public StudentAdmissionVM UpdateStudent(StudentAdmissionVM StudentAdmissionVM)
        {
            var result = _context.Update(StudentAdmissionVM);
            _context.SaveChanges();
            return result.Entity;
            //var result = _context.StudentAdmissionDetails.Where(s => s.StudentId == StudentAdmissionDetails.StudentId).FirstOrDefault();

            //if (result != null) {
            //    result.FirstName = StudentAdmissionDetails.FirstName;
            //    result.LastName = StudentAdmissionDetails.LastName;
            //    result.Gender = StudentAdmissionDetails.Gender;
            //    result.Dob = StudentAdmissionDetails.Dob;
            //    result.MobileNumber = StudentAdmissionDetails.MobileNumber;
            //    result.AdharNumber = StudentAdmissionDetails.AdharNumber;
            //    result.HighestQualification = StudentAdmissionDetails.HighestQualification;
            //    result.AddressLine1 = StudentAdmissionDetails.AddressLine1;
            //    result.AddressLine2 = StudentAdmissionDetails.AddressLine2;
            //    result.City = StudentAdmissionDetails.City;
            //    result.State = StudentAdmissionDetails.State;
            //    result.Country = StudentAdmissionDetails.Country;
            //    _context.SaveChanges();
            //    return result;
            //}
            //return null;
        }
        public void DeleteStudent(int StudentId)
        {
            var deletestudent = _context.StudentAdmissionDetails.Where(s => s.StudentId == StudentId).FirstOrDefault();
            if (deletestudent != null) {
                _context.Remove(deletestudent);
                _context.SaveChanges();
            }
        }
    }
}


