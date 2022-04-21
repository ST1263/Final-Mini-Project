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
    public class RecallInfoController : Controller
    {
        RecallInfoService _recallinfoservice;
        public RecallInfoController(RecallInfoService recallinfoservice)
        {
            _recallinfoservice = recallinfoservice;
        }

        [HttpGet]
        [Route("GetRecallInfos")]
        public IActionResult GetRecallInfos()
        {
            var allrecallinfo = _recallinfoservice.GetRecallInfos();
            return Ok(allrecallinfo);
        }

        [HttpGet]
        [Route("GetRecallInfoById")]
        public IActionResult GetRecallInfoById(int RecallinfoId)
        {
            var result = _recallinfoservice.GetRecallInfoById(RecallinfoId);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRecallInfo")]
        public IActionResult AddRecallInfo([FromBody] RecallInfoVM recallInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RecallInfo Details Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recallinfoservice.AddRecallInfo(recallInfo);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "RecallInfo Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRecallInfo")]
        public IActionResult UpdateRecallInfo(RecallInfoVM recallInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recallinfoservice.UpdateRecallInfo(recallInfo);
                return Ok(new Response { Status = "Success", Message = "Update RecallInfo    Details successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRecallInfo/{RecallinfoId}")]
        public IActionResult DeleteRecallInfo(int RecallinfoId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _recallinfoservice.DeleteRecallInfo(RecallinfoId);
                return Ok(new Response { Status = "Success", Message = "Delete RecallInfo Details Delete successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
