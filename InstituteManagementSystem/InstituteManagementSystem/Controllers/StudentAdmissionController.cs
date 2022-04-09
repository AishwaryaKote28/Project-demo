using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : Controller
    {
        IStudentAdmisionDetails _data;
        public StudentAdmissionController(IStudentAdmisionDetails data)
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
        [Route("GetSupplierById")]
        public IActionResult GetStudentByid(int id)
        {
            var result = _data.GetStudentID(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent(StudentAdmissionVM StudentAdmissionVM)
        {

            _data.AddStudent(StudentAdmissionVM);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult UpdateSupplier(StudentAdmissionVM StudentAdmissionVM)
        {          
                _data.UpdateStudent(StudentAdmissionVM);
                return Ok();       
        }
        [HttpDelete]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int StudenytId)
        {
            _data.DeleteStudent(StudenytId);
            return Ok();
        }
    }
}

