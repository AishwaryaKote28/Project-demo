using InstituteManagementSystem.Authentication;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.Service;
using InstituteManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstituteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailsController : Controller
    {
        CourseDetailsService _data;
        public CourseDetailsController(CourseDetailsService data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetCourse")]
        public IActionResult GetCourse()
        {
            var course = _data.GetCourse();
            return Ok(course);
        }
        [HttpGet]
        [Route("GetCourseById")]
        public IActionResult GetCourseID(int CourseId)
        {
            var result = _data.GetCourseID(CourseId);
            return Ok(result);
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Id not Found! Please check Id  and try again." });
        }
        [HttpGet]
        [Route("GetCourseByName")]
        public IActionResult GetCourseByName(string CourseName)
        {
            var result = _data.GetCourseByName(CourseName);
            return Ok(result);
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Id not Found! Please check Id  and try again." });
        }
        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(CourseDetailsVM CourseDetailsVM)
        {
            try {              
                _data.AddCourse(CourseDetailsVM);
                return Ok(new Response { Status = "Success", Message = "Student Added Successfully." });
            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateCourse(CourseDetailsVM CourseDetailsVM)
        {
            try { 
                _data.UpdateCourse(CourseDetailsVM);
                return Ok(new Response { Status = "Success", Message = "Updated Successfully." });
            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCourse")]
        public IActionResult DeleteCourse(int CourseID)
        {
            try {
                _data.DeleteCourse(CourseID);
                return Ok(new Response { Status = "Success", Message = "Deleted Successfully." });

            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
        }
    }
}
