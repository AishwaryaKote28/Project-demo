using InstituteManagementSystem.Data;
using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using Microsoft.EntityFrameworkCore;
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
            //Mapping model to View Model All entites
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
                              AdmissionDate = s.AdmissionDate,
                              CourseId = s.CourseId,
                              CourseDetails = s.CourseDetails
                          }).ToList();
            return result;

        }
        public StudentAdmissionVM GetStudentID(int StudentId)
        {
            var result = (from s in _context.StudentAdmissionDetails.Include(x => x.CourseDetails)
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
                              AdmissionDate = s.AdmissionDate,  
                              CourseId= s.CourseId,
                              CourseDetails = s.CourseDetails
                         }).FirstOrDefault();
            return result;
        }
        public void AddStudent(StudentAdmissionDetails StudentAdmissionDetails)
        {
            _context.Add(StudentAdmissionDetails);
            _context.SaveChanges();
        }
        public void UpdateStudent(StudentAdmissionDetails StudentAdmissionDetails)
        {
            _context.Update(StudentAdmissionDetails);
            _context.SaveChanges();        
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


