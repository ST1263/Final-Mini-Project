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
    public class RecallTypeController : Controller
    {
        RecallTypeService _recalltypeservice;
        public RecallTypeController(RecallTypeService recalltypeservice)
        {
            _recalltypeservice = recalltypeservice;
        }

        [HttpGet]
        [Route("GetRecallTypes")]
        public IActionResult GetRecallTypes()
        {
            var allrecalltype = _recalltypeservice.GetRecallTypes();
            return Ok(allrecalltype);
        }

        [HttpGet]
        [Route("GetRecallTypeById")]
        public IActionResult GetRecallTypeById(int RecallTypeId)
        {
            var result = _recalltypeservice.GetRecallTypeById(RecallTypeId);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRecallType")]
        public IActionResult AddRecallType([FromBody] RecallTypeVM recallType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RecallType Details Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recalltypeservice.AddRecallType(recallType);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "RecallType Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRecallType")]
        public IActionResult UpdateRecallType(RecallTypeVM recallType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recalltypeservice.UpdateRecallType(recallType);
                return Ok(new Response { Status = "Success", Message = "Update RecallType Details successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRecallType/{RecallTypeId}")]
        public IActionResult DeleteRecallType(int RecallTypeId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recalltypeservice.DeleteRecallType(RecallTypeId);
                return Ok(new Response { Status = "Success", Message = "Delete RecallType Details Delete successfully!" });
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
