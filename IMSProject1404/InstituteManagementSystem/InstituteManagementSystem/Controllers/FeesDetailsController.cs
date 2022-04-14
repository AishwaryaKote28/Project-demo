using InstituteManagementSystem.Authentication;
using InstituteManagementSystem.Model;
using InstituteManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeesDetailsController : Controller
    {
        FeesDetailsService _data;
        public FeesDetailsController(FeesDetailsService data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetFees")]
        public IActionResult GetAllRecords()
        {
            var record = _data.GetAllRecords();
            return Ok(record);
        }
        [HttpGet]
        [Route("GetFeesById")]
        public IActionResult GetRecieptByID(int RecieptId)
        {
            var result = _data.GetRecieptByID(RecieptId);
            return Ok(result);
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Id not Found! Please check Id  and try again." });
        }
        [HttpPost]
        [Route("AddFees")]
        public IActionResult AddCourse(FeesDetails FeesDetails)
        {
            try {
                _data.AddFees(FeesDetails);
                return Ok(new Response { Status = "Success", Message = "Student Added Successfully." });
            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateFees")]
        public IActionResult UpdateFees(FeesDetails FeesDetails)
        {
            try {
                _data.UpdateFees(FeesDetails);
                return Ok(new Response { Status = "Success", Message = "Updated Successfully." });
            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
        }
    }
}

