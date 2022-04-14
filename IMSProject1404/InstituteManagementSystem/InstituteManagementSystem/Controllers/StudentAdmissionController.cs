
using InstituteManagementSystem.Authentication;
using InstituteManagementSystem.Service;
using InstituteManagementSystem.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstituteManagementSystem.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : Controller
    {
        StudentAdmissionService _data;
        public StudentAdmissionController(StudentAdmissionService data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetStudentList")]
        public IActionResult GetStudent()
        {
            var result = _data.GetStudentList();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetStudentById")]
        public IActionResult GetStudentID(int StudentId)
        {
            try {
                var result = _data.GetStudentID(StudentId);
                return Ok(result);
            }
            catch (Exception e) {   
                return NotFound();
            }
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Id not Found! Please check Id  and try again." });
        }
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent(StudentAdmissionVM StudentAdmissionVM)
        {
            try {
                _data.AddStudent(StudentAdmissionVM);
                return Ok(new Response { Status = "Success", Message = "Student Added Successfully." });
            }
            catch (Exception e) {
                return NotFound(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult UpdateSupplier(StudentAdmissionVM StudentAdmissionVM)
        {
            try {
                _data.UpdateStudent(StudentAdmissionVM);
                return Ok(new Response { Status = "Success", Message = "Updated Successfully." });
            }
            catch (Exception e) {
                return NotFound(e.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteStudent")] 
        public IActionResult DeleteStudent(int StudenytId)
        {
            try {
                _data.DeleteStudent(StudenytId);
                return Ok(new Response { Status = "Success", Message = "Deleted Successfully." });
            }
            catch (Exception e) {
                return NotFound(e.Message);
            }

        }
    }
}