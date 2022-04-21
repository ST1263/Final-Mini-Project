using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectNS.Model;
using ProjectNS.Service;
using ProjectNS.ViewModel;
using System;

namespace ProjectNS.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class FDAClassificationController : Controller
    {
        FDAClassificationService _fdaclassificationservice;
        public FDAClassificationController(FDAClassificationService fdaclassificationservice)
        {
            _fdaclassificationservice = fdaclassificationservice;
        }

        [HttpGet]
        [Route("GetFDAClassifications")]
        public IActionResult GetFDAClassifications()
        {
            var allfdaclassification = _fdaclassificationservice.GetFDAClassifications();
            return Ok(allfdaclassification);
        }

        [HttpGet]
        [Route("GetFDAClassificationById")]
        public IActionResult GetFDAClassificationById(int FDAClassificationId)
        {
            var result = _fdaclassificationservice.GetFDAClassificationById(FDAClassificationId);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddFDAClassification")]
        public IActionResult AddFDAClassification([FromBody] FDAClassificationVM fDAClassification)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "FDA Classification Details Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _fdaclassificationservice.AddFDAClassification(fDAClassification);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "FDA Classification Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateFDAClassification")]
        public IActionResult UpdateFDAClassification(FDAClassificationVM fDAClassification)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _fdaclassificationservice.UpdateFDAClassification(fDAClassification);
                return Ok(new Response { Status = "Success", Message = "Update FDA Classification Details successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteFDAClassification/{FDAClassificationId}")]
        public IActionResult DeleteFDAClassification(int FDAClassificationId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _fdaclassificationservice.DeleteFDAClassification(FDAClassificationId);
                return Ok(new Response { Status = "Success", Message = "Delete FDA Classification Details Delete successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /* public IActionResult Index()
         {
             return View();
         }*/
    }
}
